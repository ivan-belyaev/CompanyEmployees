using System.Collections.Generic;


namespace Entities.LinkModels
{
    /// <summary>
    /// Link Resource Base contain all of our links
    /// </summary>
    public class LinkResourceBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        public LinkResourceBase()
        { }

        /// <summary>
        /// Links
        /// </summary>
        public List<Link> Links { get; set; } = new List<Link>();
    }
}
