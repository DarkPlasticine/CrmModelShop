using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CrmDL.Interface
{
    public interface IRepository<T> where T : class
    {
        #region Sync

        IQueryable<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);

        #endregion

        #region Async
        
        #endregion

    }
}
