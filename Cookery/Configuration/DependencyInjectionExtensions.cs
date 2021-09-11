using Cookery.Domain.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Cookery.API.Configuration
{
    public static class DependencyInjectionExtensions
    {
        public static void AddDependencyInjections(this IServiceCollection services, IConfiguration configuration)
        {
            //Dependency Injections Configs
            services.Configure<MongoDbConfig>(configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }
    }
}
