using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.LinkModels
{
    /// <summary>
    /// Link Response
    /// </summary>
    public class LinkResponse
    {
        /// <summary>
        /// Get/set Has Links
        /// </summary>
        public bool HasLinks { get; set; }

        /// <summary>
        /// Get/set Shaped Entities
        /// </summary>
        public List<Entity> ShapedEntities { get; set; }

        /// <summary>
        /// Get/set Linked Entities
        /// </summary>
        public LinkCollectionWrapper<Entity> LinkedEntities { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public LinkResponse()
        {
            LinkedEntities = new LinkCollectionWrapper<Entity>();
            ShapedEntities = new List<Entity>();
        }
    }
}
