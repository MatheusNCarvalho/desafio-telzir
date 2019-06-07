using ChallengeTelzir.Domain.Core.Utils;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Services.API.ViewModel.Response
{
    public class RatesResultViewModel
    {
        public EDdds DistinguishedId { get; set; }
        public string Distinguished => FunctionEnum.GetEnumDescription(DistinguishedId);
    }
}