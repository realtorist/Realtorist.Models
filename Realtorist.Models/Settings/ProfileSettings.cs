using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes settings of the website
    /// </summary>
    public class ProfileSettings
    {
        [Display(Name = "Your first name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Your last name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Your full name")]
        public string FullName => $"{FirstName} {LastName}";

        [Display(Name = "Your email")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Your phone (style it)")]
        [Required]
        [RegularExpression("^[0-9]{10}$")]
        public string Phone { get; set; }

        [Display(Name = "Your address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "URL to your picture")]
        [Required]
        [Url]
        public string Avatar { get; set; }

        [Display(Name = "Brief description of you")]
        [Required]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Theme of the admin panel
        /// </summary>
        public string AdminTheme { get; set; }
    }
}
