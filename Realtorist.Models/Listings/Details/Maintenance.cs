using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;

namespace Realtorist.Models.Listings.Details
{
    public class Maintenance
    {
        /// <summary>
        /// Condo/Maintenances fees
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Fee", GroupName = "Maintenance Fee")]
        public string Fee { get; set; }

        /// <summary>
        /// Condo/Maintenances fee payment unit (Frequency)
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Frequency", GroupName = "Maintenance Fee")]
        public PaymentUnit? Frequency { get; set; }

        /// <summary>
        /// Condo/Maintenances fee type
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Included", GroupName = "Maintenance Fee")]
        public MaintenanceFeeType[] Included { get; set; }
    }
}