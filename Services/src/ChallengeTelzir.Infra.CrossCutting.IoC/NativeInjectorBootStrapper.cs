using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Infra.Data.Context;
using ChallengeTelzir.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace ChallengeTelzir.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IFixedRatesReposiotry, FixedRatesReposiotry>();
            services.AddScoped<IDetailedCalculationConnectionValueReposiotry, DetailedCalculationConnectionValueRepository>();
        }
    }
}
