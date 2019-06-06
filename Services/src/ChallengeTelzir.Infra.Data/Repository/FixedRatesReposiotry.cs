using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Infra.Data.Context;

namespace ChallengeTelzir.Infra.Data.Repository
{
    public class FixedRatesReposiotry : Repository<FixedRates>, IFixedRatesReposiotry
    {
        public FixedRatesReposiotry(AppDbContext context) : base(context)
        {
        }
    }
}