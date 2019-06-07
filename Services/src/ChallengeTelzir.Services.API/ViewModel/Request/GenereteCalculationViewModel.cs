using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Services.API.ViewModel.Request
{
    public class GenereteCalculationViewModel
    {
        public EDdds OriginId { get; set; }
        public EDdds DistinguishedId { get; set; }
        public int Time { get; set; }
        public EPlanSpeakMore PlanSpeakMoreId { get; set; }
    }
}