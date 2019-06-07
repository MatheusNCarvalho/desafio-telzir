using ChallengeTelzir.Domain.Core.Utils;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;
using Newtonsoft.Json;

namespace ChallengeTelzir.Services.API.ViewModel.Response
{
    public class DetailedCalculationResultViewModel
    {
        [JsonConverter(typeof(EnumToStringConverter))]
        public EDdds OriginId { get; set; }
        [JsonConverter(typeof(EnumToStringConverter))]
        public EDdds DistinguishedId { get; set; }
        public int Time { get; set; }
        [JsonConverter(typeof(EnumToStringConverter))]
        public EPlanSpeakMore PlanSpeakMoreId { get; set; }
        public decimal WithoutSpeakMore { get; set; }
        public decimal WithSpeakMore { get; set; }
    }
}