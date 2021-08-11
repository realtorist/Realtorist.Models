using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum BasementDevelopment
    {
		[Display(Name = "Finished")]
		[XmlEnum(Name = "Finished")]
		Finished = 1,

		[Display(Name = "Partially finished")]
		[XmlEnum(Name = "Partially finished")]
		Partially_finished = 2,

		[Display(Name = "Unfinished")]
		[XmlEnum(Name = "Unfinished")]
		Unfinished = 3,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 16,

		[Display(Name = "Not Applicable")]
		[XmlEnum(Name = "Not Applicable")]
		Not_Applicable = 17,

		[Display(Name = "Basement Suite - Regulation")]
		[XmlEnum(Name = "Basement Suite - Regulation")]
		Basement_Suite___Regulation = 18,

		[Display(Name = "Basement Suite - Non Regulation")]
		[XmlEnum(Name = "Basement Suite - Non Regulation")]
		Basement_Suite___Non_Regulation = 19,

		[Display(Name = "Other, See Remarks")]
		[XmlEnum(Name = "Other, See Remarks")]
		Other_See_Remarks = 20
    }
}