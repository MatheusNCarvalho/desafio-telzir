using System.Collections.Generic;
using System.Linq;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;
using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTelzir.Infra.Data.Repository
{
    public class FixedRatesReposiotry : Repository<FixedRates>, IFixedRatesReposiotry
    {
        public FixedRatesReposiotry(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<FixedRates> GetDistinguishedId(EDdds originId)
        {
            return DbSet.AsNoTracking().Where(x => x.OriginId.Equals(originId));
        }
    }
}