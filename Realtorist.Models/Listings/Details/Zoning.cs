using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;

namespace Realtorist.Models.Listings.Details
{
    /// <summary>
    /// Describes zoning of the property
    /// </summary>
    public class Zoning
    {
        /// <summary>
        /// Description of the zoning
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Description", GroupName = "Zoning")]
        public string Description { get; set; }

        /// <summary>
        /// Property Zoning type
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Type", GroupName = "Zoning")]
        public ZoningType? Type { get; set; }
    }
}