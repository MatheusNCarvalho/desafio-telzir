using System;
using System.Collections.Generic;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;
using Xunit;

namespace ChallengeTelzir.Tests
{
    public class CalculateCallTest
    {

        [Fact]
        public void CriarCalculoLigacao()
        {
            var resume = new DetailedCalculationConnectionValue(EDdds.D011, EDdds.D017, 80, EPlanSpeakMore.SM60);
            resume.CalculateCall(1.70M);

            Assert.Equal(37.40M, resume.WithoutSpeakMore);
            Assert.Equal(136.00M, resume.WithSpeakMore);

        }


        private static IList<FixedRates> Initialize()
        {
            var fixedRates = new List<FixedRates>
            {
                new FixedRates(Guid.NewGuid(), EDdds.D011, EDdds.D016, 1.90M),
                new FixedRates(Guid.NewGuid(), EDdds.D016, EDdds.D011, 2.90M),
                new FixedRates(Guid.NewGuid(), EDdds.D011, EDdds.D017, 1.70M),
                new FixedRates(Guid.NewGuid(), EDdds.D017, EDdds.D011, 2.70M),
                new FixedRates(Guid.NewGuid(), EDdds.D011, EDdds.D018, 0.90M),
                new FixedRates(Guid.NewGuid(), EDdds.D018, EDdds.D011, 1.90M)
            };


            return fixedRates;
        }
    }
}