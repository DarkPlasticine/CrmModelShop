using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CrmDL.Interface
{
    interface IRepository<T> where T : class
    {
        #region Sync

        T Get(int id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        void DeleteRange(IEnumerable<T> items);


        #endregion

        #region Async

        Task<IQueryable<T>> GetAllAsync();
        Task<T> GetAsync(int id);

        #endregion

    }
}
