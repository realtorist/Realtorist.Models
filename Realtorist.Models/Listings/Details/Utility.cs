using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;

namespace Realtorist.Models.Listings.Details
{
    public class Utility
    {
        /// <summary>
        /// Type of utility available
        /// </summary>
        [DisplayableProperty]
        public UtilityType? Type { get; set; }

        /// <summary>
        /// Description of utility available
        /// </summary>
        [DisplayableProperty]
        public string Description { get; set; }
    }
}