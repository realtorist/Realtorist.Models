using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ClearCeilingHeight
    {
		[Display(Name = "Under 10 Feet")]
		[XmlEnum(Name = "Under 10 Feet")]
		Under_10_Feet = 0,

		[Display(Name = "10 to Under 14 Feet")]
		[XmlEnum(Name = "10 to Under 14 Feet")]
		_10_to_Under_14_Feet = 10,

		[Display(Name = "14 to Under 16 Feet")]
		[XmlEnum(Name = "14 to Under 16 Feet")]
		_14_to_Under_16_Feet = 14,

		[Display(Name = "16 to Under 18 Feet")]
		[XmlEnum(Name = "16 to Under 18 Feet")]
		_16_to_Under_18_Feet = 16,

		[Display(Name = "18 to Under 20 Feet")]
		[XmlEnum(Name = "18 to Under 20 Feet")]
		_18_to_Under_20_Feet = 18,

		[Display(Name = "20 to Under 22 Feet")]
		[XmlEnum(Name = "20 to Under 22 Feet")]
		_20_to_Under_22_Feet = 20,

		[Display(Name = "22 to Under 24 Feet")]
		[XmlEnum(Name = "22 to Under 24 Feet")]
		_22_to_Under_24_Feet = 22,

		[Display(Name = "24 to Under 28 Feet")]
		[XmlEnum(Name = "24 to Under 28 Feet")]
		_24_to_Under_28_Feet = 24,

		[Display(Name = "Over 28 Feet")]
		[XmlEnum(Name = "Over 28 Feet")]
		Over_28_Feet = 28
    }
}