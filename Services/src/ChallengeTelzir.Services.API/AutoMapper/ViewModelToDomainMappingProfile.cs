using AutoMapper;
using ChallengeTelzir.Domain.DTO;
using ChallengeTelzir.Services.API.ViewModel.Request;

namespace ChallengeTelzir.Services.API.AutoMapper
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<GenereteCalculationViewModel, GenereteCalculationDto>()
                .ConvertUsing((model, dto) => new GenereteCalculationDto(model.OriginId, model.DistinguishedId, model.Time, model.PlanSpeakMoreId));
        }
    }
}