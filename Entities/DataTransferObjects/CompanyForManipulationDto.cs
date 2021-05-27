
namespace Entities.DataTransferObjects
{
    /// <summary>
    /// Company For Manipulation Dto
    /// </summary>
    public abstract class CompanyForManipulationDto
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
    }
}
