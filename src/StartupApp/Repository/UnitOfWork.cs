using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _context;
        //private GenericRepository<Department> departmentRepository;


        public GenericRepository<DashBoardItem> DashBoardRepository
        {
            get
            {
                if (this._dashBoardRepository == null)
                {
                    _dashBoardRepository = new GenericRepository<DashBoardItem>(_context);
                }
                return _dashBoardRepository;
            }
        }

        
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        private GenericRepository<DashBoardItem> _dashBoardRepository;

        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
      
    }

    
}