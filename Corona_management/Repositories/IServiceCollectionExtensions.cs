using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class IServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IPersonalDetailRepository, PersonalDetailRepository>();
            serviceCollection.AddScoped<ICovidDetailRepository, CovidDetailRepository>();
            serviceCollection.AddDbContext<Corona_managementContext>(opt => opt.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\מטלת בית\Corona Management\Corona_management\DB\Corona_management.mdf;Integrated Security=True;Connect Timeout=30"));
            //return serviceCollection;
        }
    }
}
