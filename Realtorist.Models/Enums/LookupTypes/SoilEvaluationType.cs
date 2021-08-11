using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum SoilEvaluationType
    {
		[Display(Name = "Completed")]
		[XmlEnum(Name = "Completed")]
		Completed = 1,

		[Display(Name = "Pending")]
		[XmlEnum(Name = "Pending")]
		Pending = 2,

		[Display(Name = "Not Completed")]
		[XmlEnum(Name = "Not Completed")]
		Not_Completed = 3,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 4,

		[Display(Name = "See agent")]
		[XmlEnum(Name = "See agent")]
		See_agent = 5,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 6
    }
}