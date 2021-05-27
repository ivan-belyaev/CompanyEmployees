

namespace Entities.RequestFeatures
{
    /// <summary>
    /// Meta Data
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// Current Page
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Total Pages
        /// </summary>
        public int TotalPages { get; set; }

        /// <summary>
        /// Page Size
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Total Count
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Has Previous
        /// </summary>
        public bool HasPrevious => CurrentPage > 1;

        /// <summary>
        /// Has Next
        /// </summary>
        public bool HasNext => CurrentPage < TotalPages;
    }
}
