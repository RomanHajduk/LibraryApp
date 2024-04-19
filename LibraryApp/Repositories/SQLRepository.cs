namespace LibraryApp.Repositories
{
    using LibraryApp.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    public class SQLRepository<T>: IRepository<T> where T : class, IEntity
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public SQLRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T item) 
        { 
            _dbSet.Add(item);
        }

        public void Remove(T item) 
        {
            _dbSet.Remove(item);
        }
        public void Save()
        { 
            _dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }    
    }
}
