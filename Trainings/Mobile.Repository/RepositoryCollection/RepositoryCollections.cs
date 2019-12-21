using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Mobile.DBMap.Northwind_Models;
using Mobile.Repository.Abstraction;

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