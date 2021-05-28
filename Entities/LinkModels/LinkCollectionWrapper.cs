using System.Collections.Generic;


namespace Entities.LinkModels
{
    /// <summary>
    /// Link Collection Wrapper
    /// </summary>
    public class LinkCollectionWrapper<T> : LinkResourceBase
    {
        /// <summary>
        /// Value
        /// </summary>
        public List<T> Value { get; set; } = new List<T>();

        /// <summary>
        /// ctor
        /// </summary>
        public LinkCollectionWrapper()
        { }

        /// <summary>
        /// ctor
        /// </summary>
        public LinkCollectionWrapper(List<T> value)
        {
            Value = value;
        }
    }
}
