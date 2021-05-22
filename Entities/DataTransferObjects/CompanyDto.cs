using System;

namespace Entities.DataTransferObjects
{
    public class CompanyDto
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
        /// Get/sets Full Address
        /// </summary>
        public string FullAddress { get; set; }
    }
}
