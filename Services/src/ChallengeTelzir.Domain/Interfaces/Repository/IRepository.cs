using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ChallengeTelzir.Domain.Core.Models;

namespace ChallengeTelzir.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Add(TEntity obj);
        Task Add(IList<TEntity> obj);
        Task<TEntity> FindById(Guid id);
        IList<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IList<TEntity> FindAll();
        Task Remove(Guid id);
        Task SaveChanges();
    }
}