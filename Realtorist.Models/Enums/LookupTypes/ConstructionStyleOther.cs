using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ConstructionStyleOther
    {
		[Display(Name = "Manufactured")]
		[XmlEnum(Name = "Manufactured")]
		Manufactured = 1,

		[Display(Name = "Modular")]
		[XmlEnum(Name = "Modular")]
		Modular = 2,

		[Display(Name = "Seasonal")]
		[XmlEnum(Name = "Seasonal")]
		Seasonal = 3,

		[Display(Name = "Super Store")]
		[XmlEnum(Name = "Super Store")]
		Super_Store = 4,

		[Display(Name = "General Purpose")]
		[XmlEnum(Name = "General Purpose")]
		General_Purpose = 5,

		[Display(Name = "Distribution")]
		[XmlEnum(Name = "Distribution")]
		Distribution = 6,

		[Display(Name = "Truck Terminal")]
		[XmlEnum(Name = "Truck Terminal")]
		Truck_Terminal = 7,

		[Display(Name = "Service Centre")]
		[XmlEnum(Name = "Service Centre")]
		Service_Centre = 8,

		[Display(Name = "Showroom")]
		[XmlEnum(Name = "Showroom")]
		Showroom = 9,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 10,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 11,

		[Display(Name = "Basement")]
		[XmlEnum(Name = "Basement")]
		Basement = 12,

		[Display(Name = "Office Tower")]
		[XmlEnum(Name = "Office Tower")]
		Office_Tower = 13
    }
}