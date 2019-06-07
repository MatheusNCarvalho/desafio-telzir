using System.Linq;
using System.Threading.Tasks;
using ChallengeTelzir.Domain.Core.Notifications;
using ChallengeTelzir.Domain.DTO;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Handler;
using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Domain.Interfaces.Services;
using MediatR;

namespace ChallengeTelzir.Domain.Services
{
    public class GenereteCalculationService : CommandHandlerBase, IGenereteCalculationService
    {
        private readonly IFixedRatesReposiotry _fixedRatesReposiotry;
        private readonly IDetailedCalculationConnectionValueReposiotry _detailedCalculationConnection;

        public GenereteCalculationService(IMediator mediator, INotificationHandler<DomainNotification> notification, IFixedRatesReposiotry fixedRatesReposiotry, IDetailedCalculationConnectionValueReposiotry detailedCalculationConnection, IUnitOfWork unitOfWork) : base(mediator, notification, unitOfWork)
        {
            _fixedRatesReposiotry = fixedRatesReposiotry;
            _detailedCalculationConnection = detailedCalculationConnection;
        }

        public Task Add(GenereteCalculationDto dto)
        {
            var fixedExist = _fixedRatesReposiotry.Find(x => x.OriginId.Equals(dto.OriginId) && x.DistinguishedId.Equals(dto.DistinguishedId)).FirstOrDefault();

            if (fixedExist == null)
            {
                NotificationDomainError("Destino incorreto.");
                return Task.CompletedTask;
            }

            var detailedCalculation = new DetailedCalculationConnectionValue(dto.OriginId, dto.DistinguishedId, dto.Time, dto.PlanSpeakMoreId);
            detailedCalculation.CalculateCall(fixedExist.Amount);

            _detailedCalculationConnection.Add(detailedCalculation);
            if (Commit()) { }

            return Task.CompletedTask;
        }

        public void Dispose()
        {
            _fixedRatesReposiotry.Dispose();
            _detailedCalculationConnection.Dispose();
        }


    }
}