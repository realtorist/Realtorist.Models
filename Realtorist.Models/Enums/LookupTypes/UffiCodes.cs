using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum UffiCodes
    {
		[Display(Name = "Yes present")]
		[XmlEnum(Name = "Yes present")]
		Yes_present = 1,

		[Display(Name = "No never present")]
		[XmlEnum(Name = "No never present")]
		No_never_present = 2,

		[Display(Name = "Removed")]
		[XmlEnum(Name = "Removed")]
		Removed = 3,

		[Display(Name = "Partially removed")]
		[XmlEnum(Name = "Partially removed")]
		Partially_removed = 4,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 5
    }
}