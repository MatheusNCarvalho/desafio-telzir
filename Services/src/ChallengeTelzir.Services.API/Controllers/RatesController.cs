using System.Collections.Generic;
using AutoMapper;
using ChallengeTelzir.Domain.Core.Notifications;
using ChallengeTelzir.Domain.Entites.Enums;
using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Services.API.ViewModel.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeTelzir.Services.API.Controllers
{
    [Route("api/")]
    public class RatesController : BaseController
    {
        private readonly IFixedRatesReposiotry _fixedRatesReposiotry;
        private readonly IMapper _mapper;

        public RatesController(IMediator mediator, INotificationHandler<DomainNotification> notifications, IFixedRatesReposiotry fixedRatesReposiotry, IMapper mapper) : base(mediator, notifications)
        {
            _fixedRatesReposiotry = fixedRatesReposiotry;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("v1/tarifas/ddds-prdestinos")]
        public IActionResult Get(EDdds ddddId)
        {
            var result = _mapper.Map<IEnumerable<RatesResultViewModel>>(_fixedRatesReposiotry.GetDistinguishedId(ddddId));
            return Response(result);
        }
    }
}