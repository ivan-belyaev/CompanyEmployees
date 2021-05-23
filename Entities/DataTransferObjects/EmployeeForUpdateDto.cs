using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    /// <summary>
    ///  Employee For Update Dto
    /// </summary>
    public class EmployeeForUpdateDto
    {
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
