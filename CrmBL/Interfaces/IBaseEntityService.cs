using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrmDL.Models;

namespace CrmBL.Interfaces
{
    public interface IBaseEntityService<T> where T: BaseObject
    {
        void Add(T item);
        IQueryable<T> GetAll();

        void Update(T item);
        void Delete(T item);


    }
}
