using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BudgetMiner
{
    public static class AutoMapperRegistrations
    {
        public static IServiceCollection AddAutoMapper(this IServiceCollection services)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap(typeof(IEnumerable<>), typeof(List<>));
                cfg.CreateMap(typeof(List<>), typeof(List<>));
                cfg.CreateMap(typeof(ICollection<>), typeof(List<>));

                cfg.AddProfile<EntitiesToBusinessModels>();
                cfg.AddProfile<BusinessModelsToEntities>();
            });

            services.AddSingleton(Mapper.Configuration);

            return services;
        }

        class EntitiesToBusinessModels : Profile
        {
            public EntitiesToBusinessModels()
            {

            }
        }

        class BusinessModelsToEntities : Profile
        {
            public BusinessModelsToEntities()
            {

            }
        }
    }
}
