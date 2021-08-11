using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;

namespace Realtorist.Models.Listings.Details
{
    /// <summary>
    /// Waterfront type
    /// </summary>
    public class WaterFront
    {
        /// <summary>
        /// Waterfront type of the property
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Waterfront Type", GroupName = "Waterfront")]
        public WaterFrontType? Type { get; set; }

        /// <summary>
        /// Name of the waterfront the property is on
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Waterfront Name", GroupName = "Waterfront")]
        public string Name { get; set; }
    }
}