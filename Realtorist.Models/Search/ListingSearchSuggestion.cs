using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Listings.Details;
using System;

namespace Realtorist.Models.Search
{
    /// <summary>
    /// Describes model for search suggestions i.e. typeahead
    /// </summary>
    public class ListingSearchSuggestion
    {
        /// <summary>
        /// Listing ID
        /// </summary>
        public Guid ListingId { get; set; }

        /// <summary>
        /// Listing's address
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// MLS number
        /// </summary>
        public string MlsNumber { get; set; }

        /// <summary>
        /// Transaction type
        /// </summary>
        public TransactionType TransactionType { get; set; }
    }
}
