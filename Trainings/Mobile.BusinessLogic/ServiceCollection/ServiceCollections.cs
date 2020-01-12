using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mobile.Abstraction;
using Mobile.Repository.RepositoryCollection;
using Mobile.BusinessLogic.Services;

namespace Mobile.BusinessLogic.ServiceCollection
{
    public static class ServiceCollections
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDataService, DataService>();

            services.ConfigureRepositories(configuration);
        }
    }
}
