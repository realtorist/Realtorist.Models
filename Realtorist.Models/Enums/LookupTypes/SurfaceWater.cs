using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum SurfaceWater
    {
		[Display(Name = "Creek through")]
		[XmlEnum(Name = "Creek through")]
		Creek_through = 1,

		[Display(Name = "Creeks")]
		[XmlEnum(Name = "Creeks")]
		Creeks = 2,

		[Display(Name = "Ponds")]
		[XmlEnum(Name = "Ponds")]
		Ponds = 3,

		[Display(Name = "Spring(s)")]
		[XmlEnum(Name = "Spring(s)")]
		Springs = 4,

		[Display(Name = "Well(s)")]
		[XmlEnum(Name = "Well(s)")]
		Wells = 5,

		[Display(Name = "Pond or Stream")]
		[XmlEnum(Name = "Pond or Stream")]
		Pond_or_Stream = 6,

		[Display(Name = "Creek or Stream")]
		[XmlEnum(Name = "Creek or Stream")]
		Creek_or_Stream = 7,

		[Display(Name = "Lake")]
		[XmlEnum(Name = "Lake")]
		Lake = 8,

		[Display(Name = "Private Lake")]
		[XmlEnum(Name = "Private Lake")]
		Private_Lake = 9,

		[Display(Name = "Permanent Slough")]
		[XmlEnum(Name = "Permanent Slough")]
		Permanent_Slough = 10,

		[Display(Name = "Some Sloughs")]
		[XmlEnum(Name = "Some Sloughs")]
		Some_Sloughs = 11,

		[Display(Name = "No Sloughs")]
		[XmlEnum(Name = "No Sloughs")]
		No_Sloughs = 12,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13,

		[Display(Name = "Dugout")]
		[XmlEnum(Name = "Dugout")]
		Dugout = 14,

		[Display(Name = "Lake/Pond")]
		[XmlEnum(Name = "Lake/Pond")]
		Lake_Pond = 15,

		[Display(Name = "River/Stream")]
		[XmlEnum(Name = "River/Stream")]
		River_Stream = 16
    }
}