using Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        T Add(T entity);
        void Delete(T entity);
        void SaveChanges();
        IQueryable<T> GetQueryable();
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _dbContext;
        public BaseRepository()
        {
            _dbContext = new ApplicationDbContext();
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbContext.Set<T>();
        }

        T IBaseRepository<T>.GetById(int id)
        {
            return  _dbContext.Set<T>().Find(id);
        }

        List<T> IBaseRepository<T>.GetAll()
        {
            return  _dbContext
                .Set<T>()
                .ToList();
        }

        public T Add(T entity)
        {
             _dbContext.Set<T>().Add(entity);
             _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
             _dbContext.Set<T>().Remove(entity);
             _dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
