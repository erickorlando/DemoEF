using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Datos
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        internal DbContext Context;
        internal DbSet<TEntity> DbSet;

        public GenericRepository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<TEntity>();
        }

        public IQueryable<TEntity> All()
        {
            IQueryable<TEntity> query = DbSet;
            return query;
        }

        public TEntity Find(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            var results = DbSet.Where(predicate);
            return results;
        }

        public void Insert(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = Find(id);
            DbSet.Remove(entity);
        }
    }
}