using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CrmBL.Interfaces;
using CrmDL.Interface;
using CrmDL.Models;

namespace CrmBL.Services
{
   public class BaseEntityService<T>:IBaseEntityService<T> where T: BaseObject
   {
       private readonly IRepository<T> _repository;

       public BaseEntityService(IRepository<T> repository)
       {
           _repository = repository;
       }

       public void Add(T item)
       {
           _repository.Add(item);
       }

       public IQueryable<T> GetAll()
       {
           return _repository.GetAll();
       }

       public void Update(T item)
       {
           _repository.Update(item);
       }

       public void Delete(T item)
       {
           _repository.Delete(item);
       }
   }

}
