using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ConstructionStatus
    {
		[Display(Name = "New")]
		[XmlEnum(Name = "New")]
		New = 1,

		[Display(Name = "Complete")]
		[XmlEnum(Name = "Complete")]
		Complete = 5,

		[Display(Name = "Renovated")]
		[XmlEnum(Name = "Renovated")]
		Renovated = 2,

		[Display(Name = "Under Construction")]
		[XmlEnum(Name = "Under Construction")]
		Under_Construction = 3,

		[Display(Name = "Under Renovation")]
		[XmlEnum(Name = "Under Renovation")]
		Under_Renovation = 4,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 6,

		[Display(Name = "Shell")]
		[XmlEnum(Name = "Shell")]
		Shell = 7,

		[Display(Name = "Insulation upgraded")]
		[XmlEnum(Name = "Insulation upgraded")]
		Insulation_upgraded = 8
    }
}