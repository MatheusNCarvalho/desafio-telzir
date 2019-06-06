using ChallengeTelzir.Infra.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace ChallengeTelzir.Services.API.Configurations
{
    public static class DependecyInjectionConfiguration
    {
        public static void AddDIConfiguration(this IServiceCollection services)
        {
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}