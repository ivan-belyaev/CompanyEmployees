

namespace Entities.LinkModels
{
    /// <summary>
    /// Link
    /// </summary>
    public class Link
    {
        /// <summary>
        /// Href - represents a target URI
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Rel - represents a link relation type, which means it describes how the current context is related to the target resource
        /// </summary>
        public string Rel { get; set; }

        /// <summary>
        /// Method - we need an HTTP method to know how to distinguish the same target URIs
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public Link()
        { }

        /// <summary>
        /// ctor
        /// </summary>
        public Link(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }
    }
}
