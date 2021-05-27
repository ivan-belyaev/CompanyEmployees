using System.Collections.Generic;

namespace Entities.DataTransferObjects
{
    /// <summary>
    /// Company For Creation Dto
    /// </summary>
    public class CompanyForCreationDto : CompanyForManipulationDto
    {
        /// <summary>
        /// Get/sets Employees
        /// </summary>
        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
