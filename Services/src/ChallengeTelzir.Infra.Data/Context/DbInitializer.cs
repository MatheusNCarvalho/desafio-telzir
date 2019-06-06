using System;
using System.Collections.Generic;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Infra.Data.Context
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context)
        {
            context.FixedRateses.AddRange(InitializeCollections());
            context.SaveChanges();
        }


        private static IList<FixedRates> InitializeCollections()
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