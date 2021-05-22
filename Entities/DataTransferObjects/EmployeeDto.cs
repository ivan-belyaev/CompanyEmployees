using System;

namespace Entities.DataTransferObjects
{
    /// <summary>
    /// Employee Dto
    /// </summary>
    public class EmployeeDto
    {
        /// <summary>
        /// Get/sets Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get/sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get/sets Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Get/sets Position
        /// </summary>
        public string Position { get; set; }
    }
}
