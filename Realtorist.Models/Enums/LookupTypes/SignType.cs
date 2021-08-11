using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum SignType
    {
		[Display(Name = "Signband")]
		[XmlEnum(Name = "Signband")]
		Signband = 1,

		[Display(Name = "Pylon")]
		[XmlEnum(Name = "Pylon")]
		Pylon = 2,

		[Display(Name = "Directory Board")]
		[XmlEnum(Name = "Directory Board")]
		Directory_Board = 3,

		[Display(Name = "Store front")]
		[XmlEnum(Name = "Store front")]
		Store_front = 4,

		[Display(Name = "Facia")]
		[XmlEnum(Name = "Facia")]
		Facia = 5,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7
    }
}