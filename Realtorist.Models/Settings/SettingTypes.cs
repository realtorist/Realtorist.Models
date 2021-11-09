using System;
using System.Collections.Generic;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Contains contants of settings types
    /// </summary>
    public static class SettingTypes
    {
        /// <summary>
        /// Website settings type
        /// </summary>
        public const string Website = "Website";

        /// <summary>
        /// Profile settings type
        /// </summary>
        public const string Profile = "Profile";

        /// <summary>
        /// Profile settings type
        /// </summary>
        public const string Password = "Password";

        /// <summary>
        /// SMTP settings type
        /// </summary>
        public const string Smtp = "SMTP";

        /// <summary>
        /// Geo coding settings type
        /// </summary>
        public const string GeoCoding = "GeoCoding";

        /// <summary>
        /// Analytics settings type
        /// </summary>
        public const string Analytics = "Analytics";

        /// <summary>
        /// Social settings type
        /// </summary>
        public const string Social = "Social";

        /// <summary>
        /// Testimonials
        /// </summary>
        public const string Testimonials = "Testimonials";

        /// <summary>
        /// Listings
        /// </summary>
        public const string Listings = "Listings";

        /// <summary>
        /// Describes mapping between type of the setting and it's .NET type representation
        /// </summary>
        /// <value></value>
        public static readonly Dictionary<string, Type> SettingTypeMap = new Dictionary<string, Type>
        {
            { Website, typeof(WebsiteSettings) },
            { Profile, typeof(ProfileSettings) },
            { Smtp, typeof(SmtpSettings) },
            { GeoCoding, typeof(GeoCodingSettings) },
            { Analytics, typeof(AnalyticsSettings) },
            { Testimonials, typeof(Testimonial[]) },
            { Social, typeof(SocialSettings) },
            { Listings, typeof(ListingsSettings) },
        };
    }
}