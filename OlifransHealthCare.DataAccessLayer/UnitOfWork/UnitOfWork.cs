using OlifransHealthCare.DataAccessLayer.Data;
using OlifransHealthCare.DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCare.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly OlifransHealthCareDbContext _context = null;
        public UnitOfWork(OlifransHealthCareDbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool fechar = false;
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            this.fechar = true;
        }

        public IGenericRepository<T> GenericRepository<T>() where T : class
        {
            IGenericRepository<T> repo = new GenericRepository<T>(_context);
            return repo;
        }
               
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
