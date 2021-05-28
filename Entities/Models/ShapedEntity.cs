using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    /// <summary>
    /// Shaped Entity
    /// </summary>
    public class ShapedEntity
    {
        /// <summary>
        /// ctor
        /// </summary>
        public ShapedEntity()
        {
            Entity = new Entity();
        }

        /// <summary>
        /// Get/set Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Get/set Entity
        /// </summary>
        public Entity Entity { get; set; }
    }
}
