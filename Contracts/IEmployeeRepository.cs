using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    /// <summary>
    ///  Iterface Employee Repository
    /// </summary>
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Get All Employees of Company
        /// </summary>
        IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);

        /// <summary>
        /// Get Employee of Company by Id
        /// </summary>
        Employee GetEmployee(Guid companyId, Guid id, bool trackChanges);
    }
}
