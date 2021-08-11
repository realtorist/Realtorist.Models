using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FrontsOn
    {
		[Display(Name = "Road")]
		[XmlEnum(Name = "Road")]
		Road = 1,

		[Display(Name = "Highway")]
		[XmlEnum(Name = "Highway")]
		Highway = 2,

		[Display(Name = "Waterfront")]
		[XmlEnum(Name = "Waterfront")]
		Waterfront = 3,

		[Display(Name = "Alley")]
		[XmlEnum(Name = "Alley")]
		Alley = 4,

		[Display(Name = "Paved Yard")]
		[XmlEnum(Name = "Paved Yard")]
		Paved_Yard = 5,

		[Display(Name = "Courtyard")]
		[XmlEnum(Name = "Courtyard")]
		Courtyard = 6,

		[Display(Name = "Frontyard")]
		[XmlEnum(Name = "Frontyard")]
		Frontyard = 7,

		[Display(Name = "Backyard")]
		[XmlEnum(Name = "Backyard")]
		Backyard = 8,

		[Display(Name = "Parking lot")]
		[XmlEnum(Name = "Parking lot")]
		Parking_lot = 9,

		[Display(Name = "Garden")]
		[XmlEnum(Name = "Garden")]
		Garden = 10,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 11,

		[Display(Name = "Paved Road")]
		[XmlEnum(Name = "Paved Road")]
		Paved_Road = 12
    }
}