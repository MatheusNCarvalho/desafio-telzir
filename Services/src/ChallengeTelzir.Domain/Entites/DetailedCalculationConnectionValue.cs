using ChallengeTelzir.Domain.Core.Models;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Domain.Entites
{
    public class DetailedCalculationConnectionValue : Entity
    {
        public DetailedCalculationConnectionValue(EDdds originId, EDdds distinguishedId, int time, EPlanSpeakMore planSpeakMoreId)
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
        public decimal WithoutSpeakMore { get; private set; }
        public decimal WithSpeakMore { get; private set; }


        public void CalculateCall(decimal amount)
        {
            if (Time > PlanSpeakMoreId.GetHashCode())
            {
                var percentage = (0.1M * amount) + amount;
                WithoutSpeakMore = (Time - PlanSpeakMoreId.GetHashCode()) * percentage;
                WithSpeakMore = Time * amount;
            }
            else
            {
                WithoutSpeakMore = 0;
                WithSpeakMore = Time * amount;
            }
        }
    }
}