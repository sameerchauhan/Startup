using System;
using System.Data.Entity;
using Domain;
using Repository.EF;

namespace Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbContext _context;
        //private GenericRepository<Department> departmentRepository;


        private DashBoardRepository _dashBoardRepository;
        public IDashBoardRepository DashBoardRepository
        {
            get
            {
                if (_dashBoardRepository == null)
                {
                    _dashBoardRepository = new DashBoardRepository(new GenericRepository<DashBoardItem>(_context));
                }
                return _dashBoardRepository;
            }
        }

        private IEmployeeRepository _employeeRepository;
        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                if (_employeeRepository == null)
                {
                    _employeeRepository = new EmployeeRepository(new GenericRepository<Employee>(_context));
                }
                return _employeeRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        private bool _disposed = false;
        

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