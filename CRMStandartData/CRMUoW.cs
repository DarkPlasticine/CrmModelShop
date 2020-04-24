using System;
using System.Threading.Tasks;
using CrmBL.Models;
using CRMStandartData.Repository;

namespace CRMStandartData
{
    /// <summary>
    /// Класс unit of Work для работы с репозиториями
    /// </summary>
    public class CRMUoW: IDisposable
    {
        private Context db = new Context();
        private bool disposed = false;

        #region Repository

        private MarkRepository _markRepository;

        #endregion

        #region Context Repository

        public MarkRepository Mark
        {
            get
            {
                if (_markRepository == null)
                {
                    _markRepository = new MarkRepository(db);
                }

                return _markRepository;
            }
        }

        #endregion


        public void Save()
        {
            db.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }
        
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                db.Dispose();
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}