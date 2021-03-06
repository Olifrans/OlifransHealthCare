using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlifransHealthCare.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Diagnostics;

namespace OlifransHealthCare.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        internal DbSet<T> dbSet;
        private readonly OlifransHealthCareDbContext _context = null;


        public GenericRepository(DbSet<T> dbSet, OlifransHealthCareDbContext context)
        {
            this.dbSet = dbSet;
            _context = context;
        }


        public void Add(T entity)
        {
            dbSet.Add(entity);
        }


        public async Task<T> AddAsync(T entity)
        {
            dbSet.Add(entity);
            return entity;
        }


        public void DeleteByID(object id)
        {
            T entityToDelete = dbSet.Find(id);
            DeleteByID(entityToDelete);
            //Delete(entityToDelete);
        }

        public void DeleteByID(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        public async Task<T> DeleteAsync(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
            return entityToDelete;
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



        public IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> OrderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }
            if (OrderBy != null)
            {
                return OrderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public T GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public void Update(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;

        }

        public async Task<T> UpdateAsync(T entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            return entityToUpdate;
        }





    }
}
