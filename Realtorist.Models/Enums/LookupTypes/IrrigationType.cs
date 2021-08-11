using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum IrrigationType
    {
		[Display(Name = "Flood")]
		[XmlEnum(Name = "Flood")]
		Flood = 1,

		[Display(Name = "Guide pivot")]
		[XmlEnum(Name = "Guide pivot")]
		Guide_pivot = 2,

		[Display(Name = "Hand Move")]
		[XmlEnum(Name = "Hand Move")]
		Hand_Move = 3,

		[Display(Name = "Pivot")]
		[XmlEnum(Name = "Pivot")]
		Pivot = 4,

		[Display(Name = "Power sources")]
		[XmlEnum(Name = "Power sources")]
		Power_sources = 5,

		[Display(Name = "Wheel move")]
		[XmlEnum(Name = "Wheel move")]
		Wheel_move = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7
    }
}