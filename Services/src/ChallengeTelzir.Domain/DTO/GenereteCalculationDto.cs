using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Domain.DTO
{
    public class GenereteCalculationDto
    {
        public GenereteCalculationDto(EDdds originId, EDdds distinguishedId, int time, EPlanSpeakMore planSpeakMoreId)
        {
            OriginId = originId;
            DistinguishedId = distinguishedId;
            Time = time;
            PlanSpeakMoreId = planSpeakMoreId;

        }
        public EDdds OriginId { get; private set; }
        public EDdds DistinguishedId { get; private set; }
        public int Time { get; private set; }
        public EPlanSpeakMore PlanSpeakMoreId { get; private set; }

    }
}