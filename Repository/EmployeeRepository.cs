using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    /// <summary>
    /// Employee repository
    /// </summary>
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(RepositoryContext repositoryContext)
            :base(repositoryContext)
        {
        }
    }
}
