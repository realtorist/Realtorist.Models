using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Listings.Enums
{
    /// <summary>
    /// Describes source of listings
    /// </summary>
    public enum ListingSource
    {
        /// <summary>
        /// Listing was created by user manually
        /// </summary>
        [Display(Name = "User")]
        User,

        /// <summary>
        /// Listing was coming from CREA DDF feed
        /// </summary>
        [Display(Name = "CREA")]
        Crea
    }
}