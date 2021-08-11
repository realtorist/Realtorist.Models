using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Xml;

namespace Realtorist.Models.Listings.Details
{
    public class Land
    {
        /// <summary>
        /// The total size of the property
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Total size")]
        public Measurement SizeTotal { get; set; }

        /// <summary>
        /// The amount of frontage of the property
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Frontage")]
        public Measurement SizeFrontage { get; set; }

        /// <summary>
        /// Whether the property has acreage or not
        /// </summary>
        [DisplayableProperty]
        public bool Acreage { get; set; }

        /// <summary>
        /// What the land is currently used for
        /// </summary>
        [DisplayableProperty]
        public CurrentUse[] CurrentUse { get; set; }

        /// <summary>
        /// Whether the land is divisible or not (True/False)
        /// </summary>
        [DisplayableProperty]
        public bool Divisible { get; set; }

        /// <summary>
        /// The type of fence
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Fence Type")]
        public FenceType[] FenceType { get; set; }

        /// <summary>
        /// The front type
        /// </summary>
        [DisplayableProperty]
        public FrontsOn? FrontsOn { get; set; }

        /// <summary>
        /// List of sewer types on the land
        /// </summary>
        [DisplayableProperty]
        public Sewer[] Sewer { get; set; }

        /// <summary>
        /// The depth of the land
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Depth")]
        public Measurement SizeDepth { get; set; }

        /// <summary>
        /// The size of irregular land
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Irregular size")]
        public string SizeIrregular { get; set; }
    }
}