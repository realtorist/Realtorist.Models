using System;
using System.ComponentModel.DataAnnotations;
using Realtorist.Models.Enums;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes configuration for the social network link
    /// </summary>
    public class SocialNetworkLink
    {
        /// <summary>
        /// Type of the social network
        /// </summary>
        [Required]
        public SocialNetwork SocialNetwork { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [Display(Name = "URL")]
        [Required]
        [Url]
        public string Url { get; set; }
    }
}
