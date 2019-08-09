using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteConquest.Domain.Interfaces;
using TesteConquest.Infra.Data.Context;

namespace TesteConquest.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected DbSet<TEntity> DbSet;
        protected readonly ConquestContext Context;

        public RepositoryBase(ConquestContext dbContext)
        {
            Context = dbContext;
            DbSet = Context.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }
        public virtual IEnumerable<TEntity> GetAllReadOnly()
        {
            return DbSet.AsNoTracking();
        }
        public void Update(TEntity obj)
        {
            var entry = Context.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
        }

        public void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
        }

        //public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        //{
        //    return DbSet.Where(predicate);
        //}

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
