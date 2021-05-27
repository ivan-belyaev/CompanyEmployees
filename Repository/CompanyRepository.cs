using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges) =>
           await FindAll(trackChanges)
           .OrderBy(c => c.Name)
           .ToListAsync();

        /// <inheritdoc/>
        public async Task<Company> GetCompanyAsync(Guid companyId, bool trackChanges) =>
                    await FindByCondition(c => c.Id.Equals(companyId), trackChanges)
                    .SingleOrDefaultAsync();

        /// <inheritdoc/>
        public void CreateCompany(Company company) => Create(company);

        /// <inheritdoc/>
        public async Task<IEnumerable<Company>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        /// <inheritdoc/>
        public void DeleteCompany(Company company)
        {
            Delete(company);
        }
    }
}
