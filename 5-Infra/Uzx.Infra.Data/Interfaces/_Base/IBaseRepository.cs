using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Uzx.Domain.Entities._Base;

namespace Uzx.Infra.Data.Interfaces._Base
{ 
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> GetById(Guid id);
        //Task<IEnumerable<T>> GetAll();
        Task<T> Add(T single);
        Task<T> Update(T single);
        Task<List<T>> Remove(Guid id);
        Task<List<T>> GetByFilter(string condition);
       

        // IEnumerable<T> GetPagedList(Expression<Func<T, bool>> condition, Expression<Func<T, Int64>> _order, int currentPageIndex, out int Total);

        //IEnumerable<TEntity> Get();
        //TEntity GetByID(object id);
        //void Insert(TEntity entity);
        //void Delete(object id);
        //void Delete(TEntity entityToDelete);
        //void Update(TEntity entityToUpdate);
        //IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
        //IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where);
        //TEntity Get(Func<TEntity, Boolean> where);
        //void Delete(Func<TEntity, Boolean> where);
        //IEnumerable<TEntity> GetAll();
        //IQueryable<TEntity> GetWithInclude(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, params string[] include);
        //bool Exists(object primaryKey);
        //TEntity GetSingle(Func<TEntity, bool> predicate);
        //TEntity GetFirst(Func<TEntity, bool> predicate);

        void Dispose();

    }
}
