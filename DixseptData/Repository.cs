using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DixseptData
{
    public interface  IRepository<T> where T :class    
    {
        IQueryable<T> GetAll();

        IQueryable<T> Where(Expression<Func<T, bool>> predicate);

        T FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

        void Remove(Expression<Func<T, bool>> predicate);

        int Count(Expression<Func<T, bool>> predicate);

        void Update(T entity);

        void UpdateRange(IEnumerable<T> Entities);

        //List<T> FromSqlRaw(string sql);

        //List<T> FromSqlRaw(string sql, params object[] parameter);
    }

    public class Repository<T> : IRepository<T> where T : class 
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(DbContext context) 
        {
            _context = context ?? throw  new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll() => _dbSet;
        public IQueryable<T> Where(Expression<Func<T, bool>> predicate) => _dbSet.Where(predicate);
        public T FirstOrDefault(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefault(predicate);
        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefaultAsync(predicate);

        public void Add(T entity) => _dbSet.Add(entity);

        public void AddRange(IEnumerable<T> entities) => _dbSet.AddRange(entities);

        public void Remove(T entity) => _dbSet.Remove(entity);

        public void RemoveRange(IEnumerable<T> entities) => _dbSet.RemoveRange(entities);

        public void Remove(Expression<Func<T, bool>> predicate) => _dbSet.RemoveRange(Where(predicate));

        public int Count(Expression<Func<T, bool>> predicate) => _dbSet.Count(predicate);

        public void Update(T entity) => _dbSet.Update(entity);

        public void UpdateRange(IEnumerable<T> Entities) => _dbSet.UpdateRange(Entities);

        //public List<T> FromSqlRaw(string sql) => _dbSet.FromSqlRaw<T>(sql).AsNoTracking().ToList();

        //public List<T> FromSqlRaw(string sql, params object[] parameter) => _dbSet.FromSqlRaw<T>(sql, parameter).AsNoTracking().ToList();
    }
}
