using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    /// <summary>
    /// Company repository
    /// </summary>
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public CompanyRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }

        /// <inheritdoc/>
        public IEnumerable<Company> GetAllCompanies(bool trackChanges) =>
           FindAll(trackChanges)
           .OrderBy(c => c.Name)
           .ToList();

        /// <inheritdoc/>
        public Company GetCompany(Guid companyId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(companyId), trackChanges)
            .SingleOrDefault();

        /// <inheritdoc/>
        public void CreateCompany(Company company) => Create(company);

        /// <inheritdoc/>
        public IEnumerable<Company> GetByIds(IEnumerable<Guid> ids, bool trackChanges) =>
            FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToList();
    }
}
