using System;
using System.Collections.Generic;
using System.Text;

namespace TesteConquest.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        //IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

    }
}
