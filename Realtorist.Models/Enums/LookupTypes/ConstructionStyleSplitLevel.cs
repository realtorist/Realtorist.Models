using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ConstructionStyleSplitLevel
    {
		[Display(Name = "Split level")]
		[XmlEnum(Name = "Split level")]
		Split_level = 3,

		[Display(Name = "Sidesplit")]
		[XmlEnum(Name = "Sidesplit")]
		Sidesplit = 2,

		[Display(Name = "Backsplit")]
		[XmlEnum(Name = "Backsplit")]
		Backsplit = 1,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 4,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 5
    }
}