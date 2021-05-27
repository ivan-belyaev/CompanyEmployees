﻿using Contracts;
using Entities;
using Entities.Models;
using Entities.RequestFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    /// <summary>
    /// Employee repository
    /// </summary>
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        /// <inheritdoc/>
        public async Task<PagedList<Employee>> GetEmployeesAsync(Guid companyId, EmployeeParameters employeeParameters, bool trackChanges)
        {
            var employees = await FindByCondition(e => e.CompanyId.Equals(companyId), trackChanges)
              .OrderBy(e => e.Name)
              .ToListAsync();

            return PagedList<Employee>
              .ToPagedList(employees, employeeParameters.PageNumber, employeeParameters.PageSize);
        }

        /// <inheritdoc/>
        public async Task<Employee> GetEmployeeAsync(Guid companyId, Guid id, bool trackChanges) =>
            await FindByCondition(e => e.CompanyId.Equals(companyId) && e.Id.Equals(id), trackChanges)
            .SingleOrDefaultAsync();

        /// <inheritdoc/>
        public void CreateEmployeeForCompany(Guid companyId, Employee employee)
        {
            employee.CompanyId = companyId;
            Create(employee);
        }

        /// <inheritdoc/>
        public void DeleteEmployee(Employee employee)
        {
            Delete(employee);
        }
    }
}
