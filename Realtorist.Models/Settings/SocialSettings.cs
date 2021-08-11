using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings for the social networks
    /// </summary>
    public class SocialSettings
    {
        /// <summary>
        /// Gets or sets URL to the Instagram profile
        /// </summary>
        [Url]
        public string InstagramProfileUrl {get; set;}

        /// <summary>
        /// Gets or sets URL to the Facebook profile
        /// </summary>
        [Url]
        public string FacebookProfileUrl { get; set; }
    }
}