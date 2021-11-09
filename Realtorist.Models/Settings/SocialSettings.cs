using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings for the social networks
    /// </summary>
    public class SocialSettings
    {
        /// <summary>
        /// Gets or sets social networks links
        /// </summary>
        public SocialNetworkLink[] SocialNetworks { get; set; } = new SocialNetworkLink[0];
    }
}