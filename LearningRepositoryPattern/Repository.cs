using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace LearningRepositoryPattern
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        public Repository(DbContext context)
        {
            this.context = context;
        }
        public void Add(TEntity entities)
        {

            context.Set<TEntity>().Add(entities);
        }

        public void AddRange(List<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return context.Set<TEntity>().Where(predicate);
           
        }

      

        public TEntity Get(int id)
        {
            return context.Set<TEntity>().Find(id);
            
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entities)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(TEntity entities)
        {
            throw new NotImplementedException();
        }
    }
}
