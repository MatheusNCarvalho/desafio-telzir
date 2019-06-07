using AutoMapper;
using ChallengeTelzir.Domain.Core.Notifications;
using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Domain.Interfaces.Services;
using ChallengeTelzir.Domain.Services;
using ChallengeTelzir.Infra.Data.Context;
using ChallengeTelzir.Infra.Data.Repository;
using ChallengeTelzir.Infra.Data.UnitOfWork;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ChallengeTelzir.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {

            services.AddScoped<IGenereteCalculationService, GenereteCalculationService>();

            services.AddScoped<AppDbContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IFixedRatesReposiotry, FixedRatesReposiotry>();
            services.AddScoped<IDetailedCalculationConnectionValueReposiotry, DetailedCalculationConnectionValueRepository>();


            //AutoMapper
            services.AddScoped<IMapper>(sp => new Mapper(sp.GetRequiredService<IConfigurationProvider>(), sp.GetService));


            // Domain - Eventos
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
        }
    }
}
