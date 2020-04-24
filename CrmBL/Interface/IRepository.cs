using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CrmBL.Interface
{
    interface IRepository<T> where T : class
    {
        #region Sync

        T Get(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void AddRange(IEnumerable<T> items);
        void Update(T item);
        void Delete(T item);
        void DeleteRange(IEnumerable<T> items);


        #endregion

        #region Async

        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(int id);

        #endregion

    }
}
