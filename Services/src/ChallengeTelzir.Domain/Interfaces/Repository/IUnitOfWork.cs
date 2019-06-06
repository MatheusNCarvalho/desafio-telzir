using System;

namespace ChallengeTelzir.Domain.Interfaces.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}