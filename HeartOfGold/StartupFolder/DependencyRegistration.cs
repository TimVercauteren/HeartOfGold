using HeartOfGold.Business.Readers;
using HeartOfGold.Business.Writers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartOfGold
{
    public static class DependencyRegistration
    {
        public static IServiceCollection AddServices (this IServiceCollection services)
        {
            services.AddTransient<IApplicationReader, ApplicationReader>();
            services.AddTransient<IYearCostReader, YearCostReader>();
            services.AddTransient<IComponentReader, ComponentReader>();

            services.AddTransient<IApplicationWriter, ApplicationWriter>();
            services.AddTransient<IYearCostWriter, YearCostWriter>();
            services.AddTransient<IComponentWriter, ComponentWriter>();

            return services;
        }
    }
}
