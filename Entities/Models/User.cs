using Microsoft.AspNetCore.Identity;

namespace Entities.Models
{
    /// <summary>
    /// User
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name
        /// </summary>
        public string LastName { get; set; }
    }
}
