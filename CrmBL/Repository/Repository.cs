using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CrmBL.Interface;
using CrmBL.Models;

namespace CrmBL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Context context;

        public Repository(Context context)
        {
            this.context = context;
        }

        public T Get(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return this.context.Set<T>().ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return this.context.Set<T>().Where(predicate);
        }

        public void Add(T item)
        {
            this.context.Set<T>().Add(item);
        }

        public void AddRange(IEnumerable<T> items)
        {
            this.context.Set<T>().AddRange(items);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            this.context.Set<T>().Remove(item);
        }

        public void DeleteRange(IEnumerable<T> items)
        {
            this.context.Set<T>().RemoveRange(items);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await this.context.Set<T>().FindAsync(id);
        }

    }
    }
}
