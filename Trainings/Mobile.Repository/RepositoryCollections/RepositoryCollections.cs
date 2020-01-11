using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mobile.DBMap.Northwind_Models;
using Mobile.Repository.Abstraction;
using Mobile.Repository.Repositories;

namespace Mobile.Repository.RepositoryCollection
{
    public static class RepositoryCollections
    {
        public static void ConfigureRepositories(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(configuration.GetConnectionString("NorthwindConnection")));

            services.AddScoped<IDataRepository, DataRepository>();
        }
    }
}