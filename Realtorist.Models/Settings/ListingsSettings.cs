using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings related to listings
    /// </summary>
    public class ListingsSettings
    {
        /// <summary>
        /// Names of the offices to mark listings from them as favorites automatically
        /// </summary>
        [Display(Name = "Mark all listings from the following offices as favourite")]
        public string[] ListingOfficesToAutoFavouriteListings { get; set; } = new string[0];

        /// <summary>
        /// Whether to show similar listings or not
        /// </summary>
        [Display(Name = "Show similar listings")]
        [Required]
        public bool ShowSimilarListings { get; set; }

        /// <summary>
        /// Whether to show similar listings card title or not
        /// </summary>
        [Display(Name = "Similar listings title")]
        public string SimilarListingsTitle { get; set; }

        /// <summary>
        /// Number of similar listings to show
        /// </summary>
        [Display(Name = "Similar listings number")]
        [Range(1, 12)]
        public int? SimilarListingsNumber { get; set; }

        /// <summary>
        /// Max radius of similar listings to show
        /// </summary>
        [Display(Name = "Similar listings maximum distance in km")]
        [Range(1, 100)]
        public int? SimilarListingsMaxDistanceKm { get; set; }

        /// <summary>
        /// Max price difference in percentage between current listing and similar one
        /// </summary>
        [Display(Name = "Similar listings maximum price difference percentage")]
        [Range(0, 100)]
        public int? SimilarListingsMaxPriceDifferencePercentage { get; set; }

        /// <summary>
        /// Listings feeds
        /// </summary>
        [Display(Name = "Listings feeds")]
        public ListingsFeed[] Feeds { get; set; } = new ListingsFeed[0];
    }
}
