using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Helpers;
using Realtorist.Models.Models;
using Realtorist.Models.Pagination;
using Realtorist.Models.Search.Enums;
using System;

namespace Realtorist.Models.Search
{
    /// <summary>
    /// Describes search query
    /// </summary>
    public class ListingSearchRequest
    {
        /// <summary>
        /// Address to search
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Coordinates to search
        /// </summary>
        //public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Radius in meters to search from coordinates
        /// </summary>
        //public int RadiusMeters { get; set; } = Constants.DefaultMapRadiusMeters;

        /// <summary>
        /// Type of the property
        /// </summary>
        public PropertyType? PropertyType { get; set; }

        /// <summary>
        /// Type of the property
        /// </summary>
        public OwnershipType? OwnershipType { get; set; }

        /// <summary>
        /// Type of the building
        /// </summary>
        public BuildingType? BuildingType { get; set; }

        /// <summary>
        /// Type of the building
        /// </summary>
        public ConstructionStyleAttachment? ConstructionStyle { get; set; }

        /// <summary>
        /// Transaction type
        /// </summary>
        public TransactionTypeSearch? TransactionType { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Community name of the address
        /// </summary>
        public string CommunityName { get; set; }

        /// <summary>
        /// Neighbourhood name of the address
        /// </summary>
        public string Neighbourhood { get; set; }

        /// <summary>
        /// Subdivision name of the address
        /// </summary>
        public string Subdivision { get; set; }

        /// <summary>
        /// Min price
        /// </summary>
        public int? MinPrice { get; set; }

        /// <summary>
        /// Max price
        /// </summary>
        public int? MaxPrice { get; set; }

        /// <summary>
        /// Min floor area in sqft
        /// </summary>
        public int? MinAreqSqFt { get; set; }

        /// <summary>
        /// Does property need to have garage
        /// </summary>
        public bool Garage { get; set; }

        /// <summary>
        /// Does property need to be waterfront
        /// </summary>
        public bool Waterfront { get; set; }

        /// <summary>
        /// Number of bedrooms
        /// </summary>
        public RoomNumberSearch Bedrooms { get; set; }

        /// <summary>
        /// Number of bathrooms
        /// </summary>
        public RoomNumberSearch Bathrooms { get; set; }

        /// <summary>
        /// Sorting
        /// </summary>
        public ListingsSortBy SortBy { get; set; }

        /// <summary>
        /// Pagination
        /// </summary>
        public PaginationRequest Pagination { get; set; }

        /// <summary>
        /// Map boundaries
        /// </summary>
        public CoordinateBoundaries Boundaries { get; set; }
    }
}
