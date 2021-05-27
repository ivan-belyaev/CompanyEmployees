﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        /// <param name="companyId">Company Id</param>
        /// <param name="trackChanges">Track Changes</param>
        Task<IEnumerable<Employee>> GetEmployeesAsync(Guid companyId, bool trackChanges);

        /// <summary>
        /// Get Employee of Company by Id
        /// </summary>
        /// <param name="companyId">Company Id</param>
        /// <param name="id">Get employee id</param>
        /// <param name="trackChanges">Track Changes</param>
        Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges);

        /// <summary>
        /// Create Employee For Company
        /// </summary>
        /// <param name="companyId">Company Id</param>
        /// <param name="employee">Employee</param>
        void CreateEmployeeForCompany(Guid companyId, Employee employee);

        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="employee">Employee</param>
        void DeleteEmployee(Employee employee);

    }
}
