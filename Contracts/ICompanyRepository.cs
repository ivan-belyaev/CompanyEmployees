using Entities.Models;
using System;
using System.Collections.Generic;

namespace Contracts
{
    /// <summary>
    /// Iterface Company Repository
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Get All Companies
        /// </summary>
        /// <param name="trackChanges">Track Changes</param>       
        IEnumerable<Company> GetAllCompanies(bool trackChanges);

        /// <summary>
        /// Get Company
        /// </summary>
        /// <param name="companyId">Company Id</param>
        /// <param name="trackChanges">Track Changes</param>
        Company GetCompany(Guid companyId, bool trackChanges);

        /// <summary>
        /// Create Company
        /// </summary>
        /// <param name="company">Company</param>
        void CreateCompany(Company company);

        /// <summary>
        /// Get By Ids
        /// </summary>
        /// <param name="ids">Ids</param>
        /// <param name="trackChanges">Track Changes</param>
        IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges);

        /// <summary>
        /// Delete Company
        /// </summary>
        /// <param name="employee">Employee</param>
        void DeleteCompany(Company company);
    }
}
