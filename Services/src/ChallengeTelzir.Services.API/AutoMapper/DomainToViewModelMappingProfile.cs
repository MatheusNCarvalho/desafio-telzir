using AutoMapper;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Services.API.ViewModel.Response;

namespace ChallengeTelzir.Services.API.AutoMapper
{
    internal class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<FixedRates, RatesResultViewModel>();
            CreateMap<DetailedCalculationConnectionValue, DetailedCalculationResultViewModel>();
        }
    }
}