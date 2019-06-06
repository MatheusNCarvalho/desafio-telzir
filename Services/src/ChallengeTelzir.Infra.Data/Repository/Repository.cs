using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ChallengeTelzir.Domain.Core.Models;
using ChallengeTelzir.Domain.Interfaces;
using ChallengeTelzir.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTelzir.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected AppDbContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository(AppDbContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public async Task Add(TEntity obj)
        {
            await DbSet.AddAsync(obj);
            await SaveChanges();
        }

        public async Task Add(IList<TEntity> obj)
        {
            await DbSet.AddRangeAsync(obj);
            await SaveChanges();
        }


        public async Task<TEntity> FindById(Guid id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        public IList<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate).ToList();
        }

        public IList<TEntity> FindAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public async Task Remove(Guid id)
        {
            var obj = await FindById(id);
            if (obj != null)
                DbSet.Remove(obj);

            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}