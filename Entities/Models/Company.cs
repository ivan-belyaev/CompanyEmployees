using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    /// <summary>
    /// Company model
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("CompanyId")]
        public Guid Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        [Required(ErrorMessage = "Company address is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Address is 60 characters.")]
        public string Address { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Collection of Employee
        /// </summary>
        // Many-to-One Relationships
        public ICollection<Employee> Employees { get; set; }
    }
}
