using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings related to listings
    /// </summary>
    public class ListingsSettings
    {
        [Display(Name = "Mark all listings from the following offices as favourite")]
        public string[] ListingOfficesToAutoFavouriteListings { get; set; }

        [Display(Name = "Show similar listings")]
        [Required]
        public bool ShowSimilarListings { get; set; }

        [Display(Name = "Similar listings title")]
        public string SimilarListingsTitle { get; set; }

        [Display(Name = "Similar listings number")]
        [Range(1, 12)]
        public int? SimilarListingsNumber { get; set; }

        [Display(Name = "Similar listings maximum distance in km")]
        [Range(1, 100)]
        public int? SimilarListingsMaxDistanceKm { get; set; }

        [Display(Name = "Similar listings maximum price difference percentage")]
        [Range(0, 100)]
        public int? SimilarListingsMaxPriceDifferencePercentage { get; set; }
    }
}
