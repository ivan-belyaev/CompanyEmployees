using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Contracts
{
    /// <summary>
    /// Repository Base
    /// </summary>
    public interface IRepositoryBase<T>
    {
        /// <summary>
        /// Find all, trackChanges for read-only query performance
        /// </summary>
        /// <param name="trackChanges">track changes options</param>      
        IQueryable<T> FindAll(bool trackChanges);

        /// <summary>
        /// Find By Condition, trackChanges for read-only query performance
        /// </summary>
        /// <param name="expression">expression</param> 
        /// <param name="trackChanges">track changes options</param>      
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="enity">Entity</param> 
        void Create(T entity);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="enity">Entity</param> 
        void Update(T entity);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="enity">Entity</param> 
        void Delete(T entity);
    }
}
