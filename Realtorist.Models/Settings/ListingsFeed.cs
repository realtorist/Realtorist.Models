using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes configuration for the DDF connection
    /// </summary>
    public class ListingsFeed
    {
        /// <summary>
        /// Id of the feed
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Type of the feed
        /// </summary>
        public string FeedType { get; set; }

        /// <summary>
        /// Base URL to the DDF service
        /// </summary>
        [Display(Name = "URL to DDF")]
        [Required]
        [Url]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Username to connect to the feed
        /// </summary>
        [Display(Name = "DDF username")]
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Password to connect to the feed. Encrypted
        /// </summary>
        [Display(Name = "DDF password")]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Destination id of the feed
        /// </summary>
        [Display(Name = "Destination ID")]
        [Range(0, int.MaxValue)]
        public int? DestinationId { get; set; }

        /// <summary>
        /// CRON expression for the update times
        /// </summary>
        [Display(Name = "Update time")]
        public string UpdateTime { get; set; }
    }
}
