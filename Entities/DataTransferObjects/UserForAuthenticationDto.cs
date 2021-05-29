using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    /// <summary>
    ///  User For Authentication Dto
    /// </summary>
    public class UserForAuthenticationDto
    {
        /// <summary>
        ///  User Name
        /// </summary>
        [Required(ErrorMessage = "User name is required")]
        public string UserName { get; set; }

        /// <summary>
        ///  Password
        /// </summary>
        [Required(ErrorMessage = "Password name is required")]
        public string Password { get; set; }
    }
}
