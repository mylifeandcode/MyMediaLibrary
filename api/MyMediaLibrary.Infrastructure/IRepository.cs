using MyMediaLibrary.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Infrastructure.Data
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> Get();
        TEntity Get(int id);
        TEntity Add(TEntity entity, bool saveChanges = false);
        //Task<TEntity> AddAsync(TEntity entity, bool saveChanges = false);
        TEntity Update(TEntity entity, bool saveChanges = false);
        void Delete(int id);

        void SetValues(TEntity target, TEntity source);

        Task<int> UpdateAsync<T>(T entity, params Expression<Func<T, object>>[] navigations) where T : MediaEntity;
    }
}
