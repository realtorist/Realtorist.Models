using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum PoolFeatures
    {
		[Display(Name = "Pool equipment")]
		[XmlEnum(Name = "Pool equipment")]
		Pool_equipment = 6,

		[Display(Name = "Heated pool")]
		[XmlEnum(Name = "Heated pool")]
		Heated_pool = 7,

		[Display(Name = "Kidney Shaped")]
		[XmlEnum(Name = "Kidney Shaped")]
		Kidney_Shaped = 8,

		[Display(Name = "Lap Pool")]
		[XmlEnum(Name = "Lap Pool")]
		Lap_Pool = 9,

		[Display(Name = "Slide")]
		[XmlEnum(Name = "Slide")]
		Slide = 10,

		[Display(Name = "Diving Board")]
		[XmlEnum(Name = "Diving Board")]
		Diving_Board = 11,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13,

		[Display(Name = "Salt Water Pool")]
		[XmlEnum(Name = "Salt Water Pool")]
		Salt_Water_Pool = 14
    }
}