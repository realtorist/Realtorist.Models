using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Amperage
    {
		[Display(Name = "60 Amp Service")]
		[XmlEnum(Name = "60 Amp Service")]
		_60_Amp_Service = 1,

		[Display(Name = "100 Amp Service")]
		[XmlEnum(Name = "100 Amp Service")]
		_100_Amp_Service = 2,

		[Display(Name = "200 Amp Service")]
		[XmlEnum(Name = "200 Amp Service")]
		_200_Amp_Service = 3,

		[Display(Name = "600 Amp Service")]
		[XmlEnum(Name = "600 Amp Service")]
		_600_Amp_Service = 4
    }
}