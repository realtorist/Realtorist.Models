using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings for analytics
    /// </summary>
    public class AnalyticsSettings
    {
        /// <summary>
        /// Id for the Google Analytics
        /// </summary>
        /// <value></value>
        [Display(Name = "ID for the Google analytics")]
        [Required]
        public string GoogleAnalyticsId { get; set; }
    }
}