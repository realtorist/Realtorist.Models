using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes password settings
    /// </summary>
    public class PasswordSettings
    {
        public class PasswordReset
        {
            public Guid Guid { get; set; }

            public DateTime ExpirationDateUtc { get; set; }
        }

        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        public Guid Guid { get; set; }

        public PasswordReset ResetSettings { get; set; }
    }
}
