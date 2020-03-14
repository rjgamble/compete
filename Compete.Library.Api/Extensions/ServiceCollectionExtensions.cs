using Compete.Library.Api.Entities.Models.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Compete.Library.Api.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencies(this IServiceCollection services, IApplicationSettings applicationSettings)
        {
            services.AddSingleton(applicationSettings);
        }
    }
}
