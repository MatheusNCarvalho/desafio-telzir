using System.Collections.Generic;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Entites.Enums;

namespace ChallengeTelzir.Domain.Interfaces.Repository
{
    public interface IFixedRatesReposiotry : IRepository<FixedRates>
    {
        IEnumerable<FixedRates> GetDistinguishedId(EDdds originId);
    }
}