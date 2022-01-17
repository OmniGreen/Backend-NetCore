using System;
using System.Collections.Generic;
using Uzx.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Linq;
using Uzx.Infra.Data.Interfaces._Base;
using Uzx.Domain.Entities._Base;
using System.Threading.Tasks;
using Uzx.Domain.Interfaces;
using NetDevPack.Data;
using System.Linq.Expressions;
using System.Reflection;
using System.Linq.Dynamic;

namespace Uzx.Infra.Data.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : BaseEntity
    {
        public readonly UzxBaseDbContext Db;
        public readonly DbSet<T> _dbSet;


        public BaseRepository(UzxBaseDbContext context)
        {
            Db = context;
            _dbSet = context.Set<T>();
        }


        public async Task<T> GetById(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        //public async Task<IEnumerable<T>> GetAll()
        //{
        //    return await DbSet.ToListAsync();
        //}

        public async Task<T> Add(T single)
        {
            _dbSet.Add(single);
            await Db.SaveChangesAsync();
            return single;
        }

        public async Task<T> Update(T single)
        {
            _dbSet.Update(single);
            await Db.SaveChangesAsync();
            return single;
        }

        public async Task<List<T>> Remove(Guid id)
        {
            var item = await _dbSet.FindAsync(id);
            //_dbSet.Remove(item);
            item.IsDeleted = true;
            item.DtDeleted = DateTime.Now;
            _dbSet.Update(item);
            await Db.SaveChangesAsync();
            return await _dbSet.Where(p => p.IsActive==true).ToListAsync();
        }

        public async Task<List<T>> GetByFilter(string condition)
        {
           return await _dbSet.Where(condition).ToListAsync();
        }


        public void Dispose()
        {
            Db.Dispose();
        }


        ///// <summary>
        ///// generic Get method for Entities
        ///// </summary>
        ///// <returns></returns>
        //public virtual IEnumerable<TEntity> Get()
        //{
        //    IQueryable<TEntity> query = DbSet;
        //    return query.ToList();
        //}

        ///// <summary>
        ///// Generic get method on the basis of id for Entities.
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //public virtual TEntity GetByID(object id)
        //{
        //    return DbSet.Find(id);
        //}

        ///// <summary>
        ///// generic Insert method for the entities
        ///// </summary>
        ///// <param name="entity"></param>
        //public virtual void Insert(TEntity entity)
        //{
        //    DbSet.Add(entity);
        //}

        ///// <summary>
        ///// Generic Delete method for the entities
        ///// </summary>
        ///// <param name="id"></param>
        //public virtual void Delete(object id)
        //{
        //    TEntity entityToDelete = DbSet.Find(id);
        //    Delete(entityToDelete);
        //}

        ///// <summary>
        ///// Generic Delete method for the entities
        ///// </summary>
        ///// <param name="entityToDelete"></param>
        //public virtual void Delete(TEntity entityToDelete)
        //{
        //    if (Context.Entry(entityToDelete).State == EntityState.Detached)
        //    {
        //        DbSet.Attach(entityToDelete);
        //    }
        //    DbSet.Remove(entityToDelete);
        //}

        ///// <summary>
        ///// Generic update method for the entities
        ///// </summary>
        ///// <param name="entityToUpdate"></param>
        //public virtual void Update(TEntity entityToUpdate)
        //{
        //    DbSet.Attach(entityToUpdate);
        //    Context.Entry(entityToUpdate).State = EntityState.Modified;
        //}

        ///// <summary>
        ///// generic method to get many record on the basis of a condition.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public virtual IEnumerable<TEntity> GetMany(Func<TEntity, bool> where)
        //{
        //    return DbSet.Where(where).ToList();
        //}

        ///// <summary>
        ///// generic method to get many record on the basis of a condition but query able.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public virtual IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where)
        //{
        //    return DbSet.Where(where).AsQueryable();
        //}

        ///// <summary>
        ///// generic get method , fetches data for the entities on the basis of condition.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public TEntity Get(Func<TEntity, Boolean> where)
        //{
        //    return DbSet.Where(where).FirstOrDefault<TEntity>();
        //}

        ///// <summary>
        ///// generic delete method , deletes data for the entities on the basis of condition.
        ///// </summary>
        ///// <param name="where"></param>
        ///// <returns></returns>
        //public void Delete(Func<TEntity, Boolean> where)
        //{
        //    IQueryable<TEntity> objects = DbSet.Where<TEntity>(where).AsQueryable();
        //    foreach (TEntity obj in objects)
        //        DbSet.Remove(obj);
        //}

        ///// <summary>
        ///// generic method to fetch all the records from db
        ///// </summary>
        ///// <returns></returns>
        //public virtual IEnumerable<TEntity> GetAll()
        //{
        //    return DbSet.ToList();
        //}

        ///// <summary>
        ///// Inclue multiple
        ///// </summary>
        ///// <param name="predicate"></param>
        ///// <param name="include"></param>
        ///// <returns></returns>
        //public IQueryable<TEntity> GetWithInclude(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate, params string[] include)
        //{
        //    IQueryable<TEntity> query = this.DbSet;
        //    query = include.Aggregate(query, (current, inc) => current.Include(inc));
        //    return query.Where(predicate);
        //}

        ///// <summary>
        ///// Generic method to check if entity exists
        ///// </summary>
        ///// <param name="primaryKey"></param>
        ///// <returns></returns>
        //public bool Exists(object primaryKey)
        //{
        //    return DbSet.Find(primaryKey) != null;
        //}

        ///// <summary>
        ///// Gets a single record by the specified criteria (usually the unique identifier)
        ///// </summary>
        ///// <param name="predicate">Criteria to match on</param>
        ///// <returns>A single record that matches the specified criteria</returns>
        //public TEntity GetSingle(Func<TEntity, bool> predicate)
        //{
        //    return DbSet.Single<TEntity>(predicate);
        //}

        ///// <summary>
        ///// The first record matching the specified criteria
        ///// </summary>
        ///// <param name="predicate">Criteria to match on</param>
        ///// <returns>A single record containing the first record matching the specified criteria</returns>
        //public TEntity GetFirst(Func<TEntity, bool> predicate)
        //{
        //    return DbSet.First<TEntity>(predicate);
        //}


    }
}
