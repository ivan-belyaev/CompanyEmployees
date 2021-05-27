
namespace Entities.RequestFeatures
{
    /// <summary>
    /// Request Parameters: 10
    /// </summary>
    public abstract class RequestParameters
    {
        /// <summary>
        /// Max page size
        /// </summary>
        const int maxPageSize = 50;

        /// <summary>
        /// Page Number
        /// </summary>
        public int PageNumber { get; set; } = 1;

        /// <summary>
        /// Page size default 10
        /// </summary>
        private int _pageSize = 10;

        /// <summary>
        /// Get/set page size
        /// </summary>
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
