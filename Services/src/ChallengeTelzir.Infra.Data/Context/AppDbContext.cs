using ChallengeTelzir.Domain.Entites;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTelzir.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<FixedRates> FixedRateses { get; set; }
        public DbSet<DetailedCalculationConnectionValue> DetailedCalculationConnectionValues { get; set; }
    }
}