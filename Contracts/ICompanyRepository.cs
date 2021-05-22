using Entities.Models;
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
        IEnumerable<Company> GetAllCompanies(bool trackChanges);
    }
}
