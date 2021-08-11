using Realtorist.Models.Listings;
using Realtorist.Models.Models;
using Realtorist.Models.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtorist.Models.Search
{
    /// <summary>
    /// Describes search result
    /// </summary>
    public class ListingSearchResult
    {
        /// <summary>
        /// Original search
        /// </summary>
        public ListingSearchRequest Search { get; set; }

        /// <summary>
        /// Results
        /// </summary>
        public PaginationResult<Listing> Result { get; set; }

        /// <summary>
        /// Pairs of listing ID and listing coordinates for all listings that satisfy the criteria
        /// </summary>
        public ListingCoordinates[] Coordinates { get; set; }
    }
}
