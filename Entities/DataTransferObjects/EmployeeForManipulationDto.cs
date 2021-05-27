using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects
{
    /// <summary>
    ///  Employee For Manipulation Dto
    /// </summary>
    public abstract class EmployeeForManipulationDto
    {
        /// <summary>
        /// Get/sets Name
        /// </summary>
        [Required(ErrorMessage = "Employee name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string Name { get; set; }

        /// <summary>
        /// Get/sets Age
        /// </summary>
        [Range(18, int.MaxValue, ErrorMessage = "Age is required and it can't be lower than 18")]
        public int Age { get; set; }

        /// <summary>
        /// Get/sets Position
        /// </summary>
        [Required(ErrorMessage = "Position is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Position is 20 characters.")]
        public string Position { get; set; }
    }
}
