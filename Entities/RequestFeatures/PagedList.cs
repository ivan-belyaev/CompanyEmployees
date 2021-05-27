using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.RequestFeatures
{
    /// <summary>
    /// Paged List
    /// </summary>
    public class PagedList<T> : List<T>
    {
        /// <summary>
        /// Meta Data
        /// </summary>
        public MetaData MetaData { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public PagedList(List<T> items, int count, int pageNumber, int pageSize)
        {
            MetaData = new MetaData
            {
                TotalCount = count,
                PageSize = pageSize,
                CurrentPage = pageNumber,
                TotalPages = (int)Math.Ceiling(count / (double)pageSize)
            };

            AddRange(items);
        }

        /// <summary>
        /// To Paged List
        /// </summary>
        /// <param name="source">source</param>
        /// <param name="pageNumber">Page number</param>
        /// <param name="pageSize">Page size</param>
        public static PagedList<T> ToPagedList(IEnumerable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize).ToList();

            return new PagedList<T>(items, count, pageNumber, pageSize);
        }
    }
}
