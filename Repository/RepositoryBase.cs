using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    /// <summary>
    /// Repository Repository Base
    /// </summary>
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// Repository Context
        /// </summary>
        protected RepositoryContext RepositoryContext;

        /// <summary>
        /// ctor
        /// </summary>
        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        /// <inheritdoc/>
        public IQueryable<T> FindAll(bool trackChanges) =>
            !trackChanges ?
              RepositoryContext.Set<T>()
                .AsNoTracking() :
              RepositoryContext.Set<T>();

        /// <inheritdoc/>
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
            !trackChanges ?
              RepositoryContext.Set<T>()
                .Where(expression)
                .AsNoTracking() :
              RepositoryContext.Set<T>()
                .Where(expression);

        /// <inheritdoc/>
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        /// <inheritdoc/>
        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        /// <inheritdoc/>
        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
