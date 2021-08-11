using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FireplaceFuel
    {
		[Display(Name = "Wood")]
		[XmlEnum(Name = "Wood")]
		Wood = 1,

		[Display(Name = "Gas")]
		[XmlEnum(Name = "Gas")]
		Gas = 2,

		[Display(Name = "Electric")]
		[XmlEnum(Name = "Electric")]
		Electric = 3,

		[Display(Name = "Mixed")]
		[XmlEnum(Name = "Mixed")]
		Mixed = 4,

		[Display(Name = "Pellet")]
		[XmlEnum(Name = "Pellet")]
		Pellet = 5,

		[Display(Name = "Propane")]
		[XmlEnum(Name = "Propane")]
		Propane = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7,

		[Display(Name = "Oil")]
		[XmlEnum(Name = "Oil")]
		Oil = 8
    }
}