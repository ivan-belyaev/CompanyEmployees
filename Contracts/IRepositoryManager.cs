using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    ///  Iterface Repository Manager
    /// </summary>
    public interface IRepositoryManager
    {
        /// <summary>
        ///  Company
        /// </summary>
        ICompanyRepository Company { get; }

        /// <summary>
        ///  Employee
        /// </summary>
        IEmployeeRepository Employee { get; }

        /// <summary>
        ///  Save
        /// </summary>
        Task SaveAsync();
    }
}
