using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Uzx.Domain.Entities._Base;
using Uzx.Infra.TransferObjects._Base;
using Uzx.Infra.TransferObjects.Admin;

namespace Uzx.Application.Interfaces._Base
{
    public interface IBaseApp<T, TO> 
        where T : BaseEntity
        where TO : BaseTrans

    {
        Task<List<T>> Remove(Guid id);
        Task<TO> GetById(Guid id);
        Task<T> Register(T single);
        Task<T> Update(T single);
        Task<List<T>> GetByFilter(string condition);

        // IEnumerable<TEntity> Get(); 
        // TEntity GetByID(object id);
        // void Insert(TEntity entity);
        // void Delete(object id);
        // void Delete(TEntity entityToDelete);
        // void Update(TEntity entityToUpdate);
        // IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
        // IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where);
        // TEntity Get(Func<TEntity, Boolean> where);
        // void Delete(Func<TEntity, Boolean> where);
        // IEnumerable<TEntity> GetAll();
        //// IQueryable<TEntity> GetWithInclude(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, params string[] include);
        // bool Exists(object primaryKey);
        // TEntity GetSingle(Func<TEntity, bool> predicate);
        // TEntity GetFirst(Func<TEntity, bool> predicate);

        void Dispose();
    }
}
