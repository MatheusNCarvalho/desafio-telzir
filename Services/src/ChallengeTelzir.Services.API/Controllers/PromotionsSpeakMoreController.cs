using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ChallengeTelzir.Domain.Core.Notifications;
using ChallengeTelzir.Domain.DTO;
using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Domain.Interfaces.Services;
using ChallengeTelzir.Services.API.ViewModel.Request;
using ChallengeTelzir.Services.API.ViewModel.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeTelzir.Services.API.Controllers
{
    [Route("api/")]
    public class PromotionsSpeakMoreController : BaseController
    {
        private readonly IGenereteCalculationService _genereteCalculationService;
        private readonly IDetailedCalculationConnectionValueReposiotry _calculationConnection;
        private readonly IMapper _mapper;
        public PromotionsSpeakMoreController(IMediator mediator, INotificationHandler<DomainNotification> notifications, IGenereteCalculationService genereteCalculationService, IMapper mapper, IDetailedCalculationConnectionValueReposiotry calculationConnection) : base(mediator, notifications)
        {
            _genereteCalculationService = genereteCalculationService;
            _mapper = mapper;
            _calculationConnection = calculationConnection;
        }


        [HttpGet, Route("v1/fale-mais/ver-calculos")]
        public IActionResult Get()
        {
            var result = _mapper.Map<IEnumerable<DetailedCalculationResultViewModel>>(_calculationConnection.FindAll());
            return Response(result);
        }


        [HttpPost]
        [Route("v1/fale-mais/calcular-ligacoes")]
        public async Task<IActionResult> Post([FromBody] GenereteCalculationViewModel model)
        {
            if (!ModelState.IsValid)
            {
                NotificaitonErrorModelStateInvalid();
                return Response();
            }

            var dto = _mapper.Map<GenereteCalculationDto>(model);
            await _genereteCalculationService.Add(dto);
            return Response(null, 201);
        }
    }
}