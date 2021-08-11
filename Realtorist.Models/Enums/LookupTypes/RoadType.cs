using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum RoadType
    {
		[Display(Name = "Gravel road")]
		[XmlEnum(Name = "Gravel road")]
		Gravel_road = 1,

		[Display(Name = "No thru road")]
		[XmlEnum(Name = "No thru road")]
		No_thru_road = 2,

		[Display(Name = "Paved road")]
		[XmlEnum(Name = "Paved road")]
		Paved_road = 3,

		[Display(Name = "Road Not Maintained")]
		[XmlEnum(Name = "Road Not Maintained")]
		Road_Not_Maintained = 4,

		[Display(Name = "Seasonal Road")]
		[XmlEnum(Name = "Seasonal Road")]
		Seasonal_Road = 5,

		[Display(Name = "Dirt Road")]
		[XmlEnum(Name = "Dirt Road")]
		Dirt_Road = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7,

		[Display(Name = "Cul de sac")]
		[XmlEnum(Name = "Cul de sac")]
		Cul_de_sac = 8
    }
}