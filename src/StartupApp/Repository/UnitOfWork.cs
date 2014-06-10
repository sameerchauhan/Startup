using System;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _context;
        //private GenericRepository<Department> departmentRepository;


        public IDashBoardRepository DashBoardRepository
        {
            get
            {
                if (this._dashBoardRepository == null)
                {
                    _dashBoardRepository = new DashBoardRepository(new GenericRepository<DashBoardItem>(_context));
                }
                return _dashBoardRepository;
            }
        }

        public IEmployeeRepository EmployeeRepository { get; set; }


        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        private DashBoardRepository _dashBoardRepository;

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