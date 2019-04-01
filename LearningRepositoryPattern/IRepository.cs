using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace LearningRepositoryPattern
{
    interface IRepository <TEntity> where TEntity :class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entities);
        void AddRange(List<TEntity> entities);

        void Remove(TEntity entities);
        void RemoveRange(TEntity entities);

    }
}
