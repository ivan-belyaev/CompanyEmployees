using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    /// <summary>
    ///  User For Registration Dto
    /// </summary>
    public class UserForRegistrationDto
    {
        /// <summary>
        ///  First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        ///  Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        ///  User Name
        /// </summary>
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]

        /// <summary>
        ///  Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        ///  Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        ///  Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        ///  Roles
        /// </summary>
        public ICollection<string> Roles { get; set; }
    }
}
