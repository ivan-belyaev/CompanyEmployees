using Contracts;
using Entities;

namespace Repository
{
    /// <summary>
    /// Repository Managery
    /// </summary>
    public class RepositoryManager : IRepositoryManager
    {
        /// <summary>
        /// Repository Context
        /// </summary>        
        private RepositoryContext _repositoryContext;

        /// <summary>
        /// Company Repository
        /// </summary>     
        private ICompanyRepository _companyRepository;

        /// <summary>
        /// Employee Repository
        /// </summary>  
        private IEmployeeRepository _employeeRepository;

        /// <summary>
        /// ctor
        /// </summary>  
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        /// <summary>
        /// Company 
        /// </summary>  
        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);

                return _companyRepository;
            }
        }

        /// <summary>
        /// Employee 
        /// </summary>  
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);

                return _employeeRepository;
            }
        }

        /// <summary>
        /// Save changes 
        /// </summary>  
        public void Save() => _repositoryContext.SaveChanges();
    }
}