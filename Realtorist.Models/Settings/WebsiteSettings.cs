using System;
using System.ComponentModel.DataAnnotations;
using Realtorist.Models.Helpers;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings of the website
    /// </summary>
    public class WebsiteSettings
    {
        [Display(Name = "Brokerage")]
        public string Brokerage { get; set; }

        [Display(Name = "Website name")]
        [Required]
        public string WebsiteName { get; set; }

        [Display(Name = "Website title")]
        [Required]
        public string WebsiteTitle { get; set; }

        [Display(Name = "Website address")]
        [Required]
        public string WebsiteAddress { get; set; }

        [Display(Name = "Website keywords")]
        public string[] WebsiteKeywords { get; set; }

        [Display(Name = "Website description")]
        public string WebsiteDescription { get; set; }

        [Display(Name = "URL to your favicon")]
        [Required]
        [Url]
        public string Favicon { get; set; }

        [Display(Name = "URL to your logo")]
        [Url]
        public string Logo { get; set; }

        [Display(Name = "URL to your alternative logo")]
        [Url]
        public string AlternativeLogo { get; set; }

        [Display(Name = "URL to your brokerage logo")]
        [Url]
        public string BrokerageLogo { get; set; }

        [Display(Name = "URL to image for the social sharing sites")]
        [Url]
        public string SocialSharingImage { get; set; }


        [Display(Name = "Legal disclaimer")]
        public string LegalDisclaimer { get; set; }
        
        [Display(Name = "Timezone")]
        [Required]
        public string Timezone { get; set; }

        [Display(Name = "Is account required")]
        [Required]
        public bool AccountRequired { get; set; }

        public TimeZoneInfo TimezoneInfo => !Timezone.IsNullOrEmpty()
                ? TimeZoneInfo.FindSystemTimeZoneById(Timezone)
                : TimeZoneInfo.Utc;

        public DateTime GetDateTimeInTimeZoneFromUtc(DateTime utcTime) {
            if (utcTime.Kind == DateTimeKind.Local) {
                return utcTime;
            }

            return TimeZoneInfo.ConvertTimeFromUtc(utcTime, TimezoneInfo);
        }

        public DateTime GetDateTimeInUtcFromTimeZone(DateTime time)
        {
            if (time.Kind == DateTimeKind.Utc)
            {
                return time;
            }

            var timeZone = !Timezone.IsNullOrEmpty()
                ? TimeZoneInfo.FindSystemTimeZoneById(Timezone)
                : TimeZoneInfo.Utc;

            return TimeZoneInfo.ConvertTimeToUtc(time, TimezoneInfo);
        }
    }
}
