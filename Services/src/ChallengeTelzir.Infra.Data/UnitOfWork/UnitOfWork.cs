using ChallengeTelzir.Domain.Interfaces.Repository;
using ChallengeTelzir.Infra.Data.Context;

namespace ChallengeTelzir.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}