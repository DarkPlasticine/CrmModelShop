using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using CrmBL.Models;
using Microsoft.EntityFrameworkCore;

namespace CRMStandartData.Repository
{
    public class MarkRepository: IRepository<Mark>
    {
        private  readonly Context db;

        public MarkRepository(Context context)
        {
            this.db = context;
        }
        
        public ObservableCollection<Mark> GetAll()
        {
            return new ObservableCollection<Mark>(db.Marks.AsNoTracking().ToList());
        }

        public async Task<ObservableCollection<Mark>> GetAllAsync()
        {
            return new ObservableCollection<Mark>(this.db.Marks.AsNoTracking().ToListAsync().Result);
        }

        public Mark Get(int id)
        {
            return this.db.Marks.Find(id);
        }

        public async Task<Mark> GetAsync(int id)
        {
            return await this.db.Marks.FindAsync(id);
        }

        public void Add(Mark item)
        {
            try
            {
                this.db.Marks.Add(item);
                this.db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public async Task AddAsync(Mark item)
        {
            try
            {
                await this.db.Marks.AddAsync(item);
                await this.db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Update(Mark item)
        {
            try
            {
                if (item == null)
                {
                    throw new ArgumentNullException("Update item is null");
                }
                this.db.Entry(item).State = EntityState.Modified;
                this.db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Delete(Mark item)
        {
            try
            {
                var mark = Get(item.Id);

                if (mark != null)
                {
                    this.db.Marks.Remove(mark);
                    this.db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DeleteRange(ObservableCollection<Mark> item)
        {
            try
            {
                if (item != null)
                {
                    this.db.Marks.RemoveRange(item);
                    this.db.SaveChanges();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}