﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Extensions
{
    /// <summary>
    /// Repository Employee Extensions
    /// </summary>
    public static class RepositoryEmployeeExtensions
    {
        /// <summary>
        /// Filter Employees
        /// </summary>
        public static IQueryable<Employee> FilterEmployees(this IQueryable<Employee> employees, uint minAge, uint maxAge) =>
            employees.Where(e => (e.Age >= minAge && e.Age <= maxAge));

        /// <summary>
        /// Search
        /// </summary>
        public static IQueryable<Employee> Search(this IQueryable<Employee> employees, string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return employees;

            var lowerCaseTerm = searchTerm.Trim().ToLower();

            return employees.Where(e => e.Name.ToLower().Contains(lowerCaseTerm));
        }
    }
}
