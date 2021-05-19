using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    /// <summary>
    /// Employee model
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Id
        /// </summary>
        [Column("EmployeeId")]
        public Guid Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        [Required(ErrorMessage = "Age is a required field.")]
        public int Age { get; set; }

        /// <summary>
        /// Position
        /// </summary>
        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string Position { get; set; }

        /// <summary>
        /// CompanyId
        /// </summary>
        // One-to-Many Relationships
        [ForeignKey(nameof(Company))]
        public Guid CompanyId { get; set; }

        /// <summary>
        /// Company
        /// </summary>
        public Company Company { get; set; }
    }
}
