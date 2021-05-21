using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    /// <summary>
    /// Company repository
    /// </summary>
    public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
