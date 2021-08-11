using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings for geo coding
    /// </summary>
    public class GeoCodingSettings
    {
        /// <summary>
        /// API key for HERE maps
        /// </summary>
        [Display(Name = "API key for Here maps")]
        [Required]
        public string HereApiKey { get; set; }

    }
}