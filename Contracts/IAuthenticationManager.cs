using Entities.DataTransferObjects;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// Iterface Authentication Manager
    /// </summary>
    public interface IAuthenticationManager
    {
        /// <summary>
        /// ValidateUser
        /// </summary>
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);

        /// <summary>
        /// Create Token
        /// </summary>
        Task<string> CreateToken();
    }
}
