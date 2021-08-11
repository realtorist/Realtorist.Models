using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum WaterFrontType
    {
		[Display(Name = "Waterfront")]
		[XmlEnum(Name = "Waterfront")]
		Waterfront = 1,

		[Display(Name = "Waterfront on lake")]
		[XmlEnum(Name = "Waterfront on lake")]
		Waterfront_on_lake = 2,

		[Display(Name = "Waterfront on ocean")]
		[XmlEnum(Name = "Waterfront on ocean")]
		Waterfront_on_ocean = 3,

		[Display(Name = "Waterfront on river")]
		[XmlEnum(Name = "Waterfront on river")]
		Waterfront_on_river = 4,

		[Display(Name = "Waterfront on pond")]
		[XmlEnum(Name = "Waterfront on pond")]
		Waterfront_on_pond = 5,

		[Display(Name = "Waterfront on stream")]
		[XmlEnum(Name = "Waterfront on stream")]
		Waterfront_on_stream = 6,

		[Display(Name = "Waterfront on creek")]
		[XmlEnum(Name = "Waterfront on creek")]
		Waterfront_on_creek = 7,

		[Display(Name = "Waterfront nearby")]
		[XmlEnum(Name = "Waterfront nearby")]
		Waterfront_nearby = 8,

		[Display(Name = "Waterfront on canal")]
		[XmlEnum(Name = "Waterfront on canal")]
		Waterfront_on_canal = 9,

		[Display(Name = "Deeded water access")]
		[XmlEnum(Name = "Deeded water access")]
		Deeded_water_access = 10,

		[Display(Name = "Restricted waterfront")]
		[XmlEnum(Name = "Restricted waterfront")]
		Restricted_waterfront = 12,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13,

		[Display(Name = "Waterfront, Road Between")]
		[XmlEnum(Name = "Waterfront, Road Between")]
		Waterfront_Road_Between = 14,

		[Display(Name = "Island")]
		[XmlEnum(Name = "Island")]
		Island = 15,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 16
    }
}