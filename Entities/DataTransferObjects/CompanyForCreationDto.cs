using System.Collections.Generic;

namespace Entities.DataTransferObjects
{
    /// <summary>
    /// Company For Creation Dto
    /// </summary>
    public class CompanyForCreationDto
    {
        /// <summary>
        /// Get/sets Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get/sets Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Get/sets Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Get/sets Employees
        /// </summary>
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
