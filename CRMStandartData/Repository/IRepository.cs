using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CrmBL.Models;

namespace CRMStandartData.Repository
{
    public interface IRepository<T> where T : class
    {

        #region Sync

        T Get(int id);
        ObservableCollection<T> GetAll();
        ObservableCollection<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T item);
        void AddRange(T item);
        void Update(T item);
        void Delete(T item);
        void DeleteRange(T item);


        #endregion

        #region Async

        Task<ObservableCollection<T>> GetAllAsync();
        Task<T> GetAsync(int id);

        #endregion
        
    } 
}