
namespace Entities.RequestFeatures
{
    /// <summary>
    /// Employee Parameters
    /// </summary>
    public class EmployeeParameters : RequestParameters
    {
        /// <summary>
        /// Min Age
        /// </summary>
        public uint MinAge { get; set; }

        /// <summary>
        /// Max Age
        /// </summary>
        public uint MaxAge { get; set; } = int.MaxValue;

        /// <summary>
        /// Valid Age Range
        /// </summary>
        public bool ValidAgeRange => MaxAge > MinAge;
    }
}
