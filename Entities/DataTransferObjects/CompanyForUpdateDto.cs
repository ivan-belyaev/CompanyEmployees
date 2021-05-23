using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    /// <summary>
    /// Company For Update Dto
    /// </summary>
    public class CompanyForUpdateDto
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
