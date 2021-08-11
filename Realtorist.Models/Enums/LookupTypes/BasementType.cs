using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum BasementType
    {
		[Display(Name = "Full")]
		[XmlEnum(Name = "Full")]
		Full = 4,

		[Display(Name = "Partial")]
		[XmlEnum(Name = "Partial")]
		Partial = 5,

		[Display(Name = "Under floor space")]
		[XmlEnum(Name = "Under floor space")]
		Under_floor_space = 6,

		[Display(Name = "Crawl space")]
		[XmlEnum(Name = "Crawl space")]
		Crawl_space = 7,

		[Display(Name = "Cellar")]
		[XmlEnum(Name = "Cellar")]
		Cellar = 8,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 9,

		[Display(Name = "Remodeled Basement")]
		[XmlEnum(Name = "Remodeled Basement")]
		Remodeled_Basement = 19,

		[Display(Name = "Dugout")]
		[XmlEnum(Name = "Dugout")]
		Dugout = 20,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 21,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 17,

		[Display(Name = "Common")]
		[XmlEnum(Name = "Common")]
		Common = 18,

		[Display(Name = "N/A")]
		[XmlEnum(Name = "N/A")]
		N_A = 22
    }
}