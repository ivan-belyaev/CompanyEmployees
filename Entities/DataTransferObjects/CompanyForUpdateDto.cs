using System.Collections.Generic;

namespace Entities.DataTransferObjects
{
    /// <summary>
    /// Company For Update Dto
    /// </summary>
    public class CompanyForUpdateDto : CompanyForManipulationDto
    {
        /// <summary>
        /// Get/sets Employees
        /// </summary>
        public IEnumerable<CompanyForUpdateDto> Employees { get; set; }
    }
}
