using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Infra.Data.Context;

namespace ChallengeTelzir.Infra.Data.Repository
{
    public class DetailedCalculationConnectionValueRepository : Repository<DetailedCalculationConnectionValue>, IDetailedCalculationConnectionValueReposiotry
    {
        public DetailedCalculationConnectionValueRepository(AppDbContext context) : base(context)
        {
        }
    }
}