using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CrmDL.Interface;
using CrmDL.EF;
using Microsoft.EntityFrameworkCore;

namespace CrmDL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Context _context;

        public Repository(Context context)
        {
            this._context = context;
        }

        public IQueryable<T> GetAll()
        {
            return this._context.Set<T>().AsNoTracking();
        }
        
        public void Add(T item)
        {
            this._context.Set<T>().Add(item);
        }

        public void Update(T item)
        {
            this._context.Set<T>().Update(item);
        }

        public void Delete(T item)
        {
            this._context.Set<T>().Remove(item);
        }
    }
}
