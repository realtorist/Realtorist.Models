using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Listings.Details;

namespace Realtorist.Models.Listings
{
    /// <summary>
    /// Describes the listing in the Database
    /// </summary>
    public class Listing
    {
        /// <summary>
        /// Internal listing Id.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Marks the property as featured
        /// </summary>
        [Display(Name = "Is Featured")]
        public bool Featured { get; set; }

        /// <summary>
        /// Hides the property from search
        /// </summary>
        [Display(Name = "Is Disabled")]
        public bool Disabled { get; set; }

        [Display(Name = "Feed type")]
        [MaybeNull]
        public string? FeedType { get; set; }

        /// <summary>
        /// Id of the feed
        /// </summary>
        [Display(Name = "Feed ID")]
        public Guid? FeedId { get; set; }

        /// <summary>
        /// Real estate board
        /// </summary>
        [Display(Name = "Board")]
        public string Board { get; set; }

        /// <summary>
        /// Name of the listing office
        /// </summary>
        [Display(Name = "Listing office name")]
        public string ListingOfficeName { get; set; }

        /// <summary>
        /// Address of property
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// If listing is coming from MLS system -> contains listing id in MLS (not MLS number)
        /// </summary>
        [Display(Name = "External id")]
        [MaybeNull]
        public string ExternalId { get; set; }

        /// <summary>
        /// The MLS Number of the property.
        /// </summary>
        [Display(Name = "MLS® Number")]
        public string MlsNumber { get; set; }

        /// <summary>
        /// The date the property was last updated
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Building details of the property
        /// </summary>
        public Building Building { get; set; }

        /// <summary>
        /// Details about the land of the property
        /// </summary>
        [MaybeNull]
        public Land Land { get; set; }

        /// <summary>
        /// Set of links to information about the property
        /// </summary>
        [MaybeNull]
        public AlternateURL AlternateURL { get; set; }

        /// <summary>
        /// List of amenities nearby to the property
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public AmenitiesNearby[] AmmenitiesNearBy { get; set; }

        /// <summary>
        /// The property features available
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public Features[] Features { get; set; }

        /// <summary>
        /// A description of the location
        /// </summary>
        [MaybeNull]
        public string Description { get; set; }

        /// <summary>
        /// Maintenance of the property
        /// </summary>
        [MaybeNull]
        public Maintenance Maintenance { get; set; }

        /// <summary>
        /// The type of ownership ex: Condo/Strata, freehold etc.
        /// </summary>
        [SummaryProperty(4)]
        [Display(Name = "Title")]
        public OwnershipType? OwnershipType { get; set; }

        /// <summary>
        /// Type of transaction (e.g. sale, lease)
        /// </summary>
        public TransactionType? TransactionType { get; set; }

        /// <summary>
        /// Parking spaces
        /// </summary>
        [TableView]
        public Parking[] ParkingSpaces { get; set; }

        /// <summary>
        /// The total number of parking spaces
        /// </summary>
        [SummaryProperty(6)]
        public int? ParkingSpaceTotal { get; set; }

        /// <summary>
        /// Price of the Property
        /// </summary>
        public double? Price { get; set; }

        /// <summary>
        /// Price of property per time
        /// </summary>
        public PaymentUnit? PricePerTime { get; set; }

        /// <summary>
        /// Price of property per unit
        /// </summary>
        public MeasureUnit? PricePerUnit { get; set; }

        /// <summary>
        /// Type of real estate property
        /// </summary>
        [SummaryProperty(1)]
        public PropertyType? PropertyType { get; set; }

        /// <summary>
        /// Description of the property
        /// </summary>
        public string AdditinalRemarks { get; set; }

        /// <summary>
        /// Waterfront of the property
        /// </summary>
        /// <value></value>
        [MaybeNull]
        public WaterFront WaterFront { get; set; }

        /// <summary>
        /// Property's zoning
        /// </summary>
        [MaybeNull]
        public Zoning Zoning { get; set; }

        /// <summary>
        /// Collection of open house Events
        /// </summary>
        [TableView]
        public Event[] OpenHouse { get; set; }

        /// <summary>
        /// Collection of Live Streame Open House events
        /// </summary>
        [TableView]
        public Event[] LiveStream { get; set; }

        /// <summary>
        /// Listing photos
        /// </summary>
        public Photo[] Photos { get; set; }

        /// <summary>
        /// Number of views of the listing
        /// </summary>
        public int Views { get; set; }
    }
}
