using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum BasementFeatures
    {
		[Display(Name = "Six feet and over")]
		[XmlEnum(Name = "Six feet and over")]
		Six_feet_and_over = 10,

		[Display(Name = "Less than six feet.")]
		[XmlEnum(Name = "Less than six feet.")]
		Less_than_six_feet = 11,

		[Display(Name = "Apartment in basement")]
		[XmlEnum(Name = "Apartment in basement")]
		Apartment_in_basement = 12,

		[Display(Name = "Unrestricted height")]
		[XmlEnum(Name = "Unrestricted height")]
		Unrestricted_height = 13,

		[Display(Name = "Separate entrance")]
		[XmlEnum(Name = "Separate entrance")]
		Separate_entrance = 14,

		[Display(Name = "Walk out")]
		[XmlEnum(Name = "Walk out")]
		Walk_out = 15,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 18,

		[Display(Name = "Low")]
		[XmlEnum(Name = "Low")]
		Low = 19,

		[Display(Name = "Slab")]
		[XmlEnum(Name = "Slab")]
		Slab = 20,

		[Display(Name = "Walk-up")]
		[XmlEnum(Name = "Walk-up")]
		Walk_up = 21,

		[Display(Name = "Suite")]
		[XmlEnum(Name = "Suite")]
		Suite = 22
    }
}