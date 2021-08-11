using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum TopographyType
    {
		[Display(Name = "Hillside")]
		[XmlEnum(Name = "Hillside")]
		Hillside = 1,

		[Display(Name = "Flat")]
		[XmlEnum(Name = "Flat")]
		Flat = 24,

		[Display(Name = "Some sloughs")]
		[XmlEnum(Name = "Some sloughs")]
		Some_sloughs = 23,

		[Display(Name = "Permanent sloughs")]
		[XmlEnum(Name = "Permanent sloughs")]
		Permanent_sloughs = 22,

		[Display(Name = "No sloughs")]
		[XmlEnum(Name = "No sloughs")]
		No_sloughs = 21,

		[Display(Name = "Mountain")]
		[XmlEnum(Name = "Mountain")]
		Mountain = 20,

		[Display(Name = "Medium Rolling")]
		[XmlEnum(Name = "Medium Rolling")]
		Medium_Rolling = 19,

		[Display(Name = "Level")]
		[XmlEnum(Name = "Level")]
		Level = 18,

		[Display(Name = "Gently Rolling")]
		[XmlEnum(Name = "Gently Rolling")]
		Gently_Rolling = 17,

		[Display(Name = "Dry")]
		[XmlEnum(Name = "Dry")]
		Dry = 16,

		[Display(Name = "Beach")]
		[XmlEnum(Name = "Beach")]
		Beach = 15,

		[Display(Name = "Hazardous land")]
		[XmlEnum(Name = "Hazardous land")]
		Hazardous_land = 14,

		[Display(Name = "Marsh")]
		[XmlEnum(Name = "Marsh")]
		Marsh = 13,

		[Display(Name = "Wetlands")]
		[XmlEnum(Name = "Wetlands")]
		Wetlands = 12,

		[Display(Name = "Flood plain")]
		[XmlEnum(Name = "Flood plain")]
		Flood_plain = 11,

		[Display(Name = "Flat site")]
		[XmlEnum(Name = "Flat site")]
		Flat_site = 10,

		[Display(Name = "Open space")]
		[XmlEnum(Name = "Open space")]
		Open_space = 9,

		[Display(Name = "Waterway")]
		[XmlEnum(Name = "Waterway")]
		Waterway = 8,

		[Display(Name = "Rolling")]
		[XmlEnum(Name = "Rolling")]
		Rolling = 7,

		[Display(Name = "Ravine")]
		[XmlEnum(Name = "Ravine")]
		Ravine = 6,

		[Display(Name = "Sloping")]
		[XmlEnum(Name = "Sloping")]
		Sloping = 5,

		[Display(Name = "Rocky")]
		[XmlEnum(Name = "Rocky")]
		Rocky = 4,

		[Display(Name = "Cleared")]
		[XmlEnum(Name = "Cleared")]
		Cleared = 3,

		[Display(Name = "Level lot")]
		[XmlEnum(Name = "Level lot")]
		Level_lot = 2,

		[Display(Name = "Hilly")]
		[XmlEnum(Name = "Hilly")]
		Hilly = 25,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 26
    }
}