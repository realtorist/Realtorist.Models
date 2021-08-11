using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum RoomLevel
    {
		[Display(Name = "Second level")]
		[XmlEnum(Name = "Second level")]
		Second_level = 1,

		[Display(Name = "In between")]
		[XmlEnum(Name = "In between")]
		In_between = 15,

		[Display(Name = "Ground level")]
		[XmlEnum(Name = "Ground level")]
		Ground_level = 14,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13,

		[Display(Name = "Upper Level")]
		[XmlEnum(Name = "Upper Level")]
		Upper_Level = 12,

		[Display(Name = "Sub-basement")]
		[XmlEnum(Name = "Sub-basement")]
		Sub_basement = 11,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 10,

		[Display(Name = "Loft")]
		[XmlEnum(Name = "Loft")]
		Loft = 16,

		[Display(Name = "Main level")]
		[XmlEnum(Name = "Main level")]
		Main_level = 9,

		[Display(Name = "Flat")]
		[XmlEnum(Name = "Flat")]
		Flat = 7,

		[Display(Name = "Basement")]
		[XmlEnum(Name = "Basement")]
		Basement = 6,

		[Display(Name = "Above")]
		[XmlEnum(Name = "Above")]
		Above = 5,

		[Display(Name = "Fifth level")]
		[XmlEnum(Name = "Fifth level")]
		Fifth_level = 4,

		[Display(Name = "Fourth level")]
		[XmlEnum(Name = "Fourth level")]
		Fourth_level = 3,

		[Display(Name = "Third level")]
		[XmlEnum(Name = "Third level")]
		Third_level = 2,

		[Display(Name = "Lower level")]
		[XmlEnum(Name = "Lower level")]
		Lower_level = 8,

		[Display(Name = "Sixth Level")]
		[XmlEnum(Name = "Sixth Level")]
		Sixth_Level = 17
    }
}