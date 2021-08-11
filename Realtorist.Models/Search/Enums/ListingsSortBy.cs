using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Search.Enums
{
    /// <summary>
    /// Listings sort types
    /// </summary>
    public enum ListingsSortBy
    {
        /// <summary>
        /// Newest added
        /// </summary>
        [Display(Name = "Date Posted (new to old)")]
        DateNewest,

        /// <summary>
        /// Newest added
        /// </summary>
        [Display(Name = "Date Posted (old to new)")]
        DateOldest,

        /// <summary>
        /// Price ascending
        /// </summary>
        [Display(Name = "Price (low to high)")]
        PriceAsc,

        /// <summary>
        /// Price descending
        /// </summary>
        [Display(Name = "Price (high to low)")]
        PriceDesc
    }
}
