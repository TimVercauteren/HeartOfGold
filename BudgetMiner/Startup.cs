using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BudgetMiner.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;

namespace BudgetMiner
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            var appEnv = PlatformServices.Default.Application;
            ApplicationBasePath = appEnv.ApplicationBasePath;
            ConfigurationPath = Path.Combine(environment.ContentRootPath, "_config");

            var builder = new ConfigurationBuilder()
                .SetBasePath(ConfigurationPath)
                .AddJsonFile("dataaccess.json");

            Configuration = builder.Build();
        }

        public string ApplicationBasePath { get; private set; }
        public string ConfigurationPath { get; private set; }
        public IConfigurationRoot Configuration { get; private set; }



        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EntityContext>(options => options.UseSqlServer(GetConnectionString()));



            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private string GetConnectionString()
        {
            var configSection = Configuration.GetSection("ConnectionString");

            var host = configSection.GetValue<string>("Host");
            var dbname = configSection.GetValue<string>("DbName");
            var user = configSection.GetValue<string>("User");
            var pwd = configSection.GetValue<string>("Password");

            var sqlConnectionString = $"Server = tcp:budgetminer.database.windows.net,1433; Initial Catalog = budgetminer; Persist Security Info = False; User ID = { user }; Password ={ pwd }; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";

            return sqlConnectionString;
        }
    }
}
