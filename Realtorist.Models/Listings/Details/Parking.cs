using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Listings.Details
{
    public class Parking
    {
        /// <summary>
        /// Type of parking available
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Parking")]
        public ParkingType Name { get; set; }

        /// <summary>
        /// Number of spaces for the associated parking type
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Parking")]
        public int? Spaces { get; set; }
    }
}