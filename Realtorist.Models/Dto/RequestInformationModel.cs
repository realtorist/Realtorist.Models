using Realtorist.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Dto
{
    /// <summary>
    /// Describes customer request
    /// </summary>
    public class RequestInformationModel
    {
        public Guid? ListingId { get; set; }

        public string Address { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [RegularExpression("\\([0-9]{3}\\) [0-9]{3}-[0-9]{4}", ErrorMessage = "Phone number is incorrect")]
        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is incorrect")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public RequestType Type { get; set; }

        public Iam Iam { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
