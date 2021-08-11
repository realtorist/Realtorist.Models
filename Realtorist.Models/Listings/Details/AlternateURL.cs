using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Listings.Details
{
    /// <summary>
    /// Additional URLs
    /// </summary>
    public class AlternateURL
    {
        /// <summary>
        /// Link to brochure web site or document
        /// </summary>
        [Display(Name = "Brochure")]
        public string BrochureLink { get; set; }

        /// <summary>
        /// Link to a mapping site displaying the property location
        /// </summary>
        [Display(Name = "Map")]
        public string MapLink { get; set; }

        /// <summary>
        /// Link to a site containing additional photos
        /// </summary>
        [Display(Name = "Photo")]
        public string PhotoLink { get; set; }

        /// <summary>
        /// Link to a site containing sound clips
        /// </summary>
        [Display(Name = "Sounds")]
        public string SoundLink { get; set; }

        /// <summary>
        /// Link to a site containing video for the property
        /// </summary>
        [Display(Name = "Video")]
        public string VideoLink { get; set; }
    }
}