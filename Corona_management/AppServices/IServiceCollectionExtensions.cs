using AppServices.Profiles;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppServices
{
    public static class IServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPersonalDetailServices, PersonalDetailServices>();
            serviceCollection.AddScoped<ICovidDetailServices, CovidDetailServices>();
            serviceCollection.AddRepositories();
            serviceCollection.AddAutoMapper(config => config.AddProfile<PersonalDetailProfile>());
            serviceCollection.AddAutoMapper(config => config.AddProfile<covidDetailProfile>());

            serviceCollection.AddRepositories();
            //return serviceCollection;
        }
    }

}
