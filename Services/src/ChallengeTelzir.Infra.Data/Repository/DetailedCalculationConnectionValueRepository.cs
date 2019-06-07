using System.Collections.Generic;
using System.Linq;
using ChallengeTelzir.Domain.Entites;
using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTelzir.Infra.Data.Repository
{
    public class DetailedCalculationConnectionValueRepository : Repository<DetailedCalculationConnectionValue>, IDetailedCalculationConnectionValueReposiotry
    {
        public DetailedCalculationConnectionValueRepository(AppDbContext context) : base(context)
        {
        }

        public override IList<DetailedCalculationConnectionValue> FindAll()
        {
            return DbSet.AsNoTracking().OrderByDescending(x => x.CreationDate).ToList();
        }
    }
}