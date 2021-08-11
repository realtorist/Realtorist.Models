using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes SMTP settings
    /// </summary>
    public class SmtpSettings
    {
        /// <summary>
        /// SMTP host
        /// </summary>
        [Display(Name = "Host")]
        [Required]
        public string Host { get; set; }

        /// <summary>
        /// SMTP port
        /// </summary>
        [Display(Name = "Port")]
        [Required]
        [Range(0, 100000)]
        public int Port { get; set; }

        /// <summary>
        /// Username to connect
        /// </summary>
        [Display(Name = "SMTP username")]
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Password to connect
        /// </summary>
        [Display(Name = "SMTP password")]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Whether SMTP is using SSL
        /// </summary>
        [Display(Name = "TLS/SSL")]
        public bool EnableSsl { get; set; }

        /// <summary>
        /// Email address to send from
        /// </summary>
        [Display(Name = "Email address")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
