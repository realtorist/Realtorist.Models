using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Enums;
using Realtorist.Models.Helpers;

namespace Realtorist.Models.Pagination
{
    /// <summary>
    /// Describes request's pagination
    /// </summary>
    public class PaginationRequest
    {
        /// <summary>
        /// Creates new instance of <see cref="PaginationRequest"/>
        /// </summary>
        public PaginationRequest()
        {
        }

        /// <summary>
        /// Creates new instance of <see cref="PaginationRequest"/>
        /// </summary>
        /// <param name="offset">Current page</param>
        /// <param name="limit">Number of the max records requested</param>
        public PaginationRequest(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }

        /// <summary>
        /// Current page
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Number of the max records requested
        /// </summary>
        public int Limit { get; set; } = Constants.DefaultPaginationLimit;

        /// <summary>
        /// Number of the elements to skip in result
        /// </summary>
        public int Offset => Limit * (Page - 1);

        /// <summary>
        /// Name of the field to sort result
        /// </summary>
        [MaybeNull]
        public string SortField { get; set; }

        /// <summary>
        /// Sorting order. <see cref="SortField"/> should be set
        /// </summary>
        /// <value></value>
        public SortByOrder SortOrder { get; set;}

        /// <summary>
        /// Creates new pagination request from <paramref name="offset"/> and <paramref name="limit"/>
        /// </summary>
        /// <param name="offset">Offset</param>
        /// <param name="limit">Limit</param>
        /// <returns>Pagination request</returns>
        public static PaginationRequest FromOffset(int offset, int limit) => new PaginationRequest(offset / limit + 1, limit);

        /// <summary>
        /// Creates new pagination request from <paramref name="offset"/> and <see cref="DefaultLimit"/> limit
        /// </summary>
        /// <param name="offset">Offset</param>
        /// <returns>Pagination request</returns>
        public static PaginationRequest FromOffset(int offset) => FromOffset(offset, Constants.DefaultPaginationLimit);
    }
}
