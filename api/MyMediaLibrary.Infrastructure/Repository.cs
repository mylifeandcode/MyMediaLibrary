using MyMediaLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Infrastructure.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : MediaEntity
    {
        public TEntity Add(TEntity entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> Get()
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public void SetValues(TEntity target, TEntity source)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity, bool saveChanges = false)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync<T>(T entity, params Expression<Func<T, object>>[] navigations) where T : MediaEntity
        {
            throw new NotImplementedException();
        }
    }
}
