using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum UtilityPower
    {
		[Display(Name = "220v Entry")]
		[XmlEnum(Name = "220v Entry")]
		_220v_Entry = 1,

		[Display(Name = "100 Amp Service")]
		[XmlEnum(Name = "100 Amp Service")]
		_100_Amp_Service = 2,

		[Display(Name = "200 Amp Service")]
		[XmlEnum(Name = "200 Amp Service")]
		_200_Amp_Service = 3,

		[Display(Name = "600 Amp Service")]
		[XmlEnum(Name = "600 Amp Service")]
		_600_Amp_Service = 4,

		[Display(Name = "Pole Line")]
		[XmlEnum(Name = "Pole Line")]
		Pole_Line = 5,

		[Display(Name = "Underground to House")]
		[XmlEnum(Name = "Underground to House")]
		Underground_to_House = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7,

		[Display(Name = "Single Phase")]
		[XmlEnum(Name = "Single Phase")]
		Single_Phase = 8,

		[Display(Name = "Three Phase")]
		[XmlEnum(Name = "Three Phase")]
		Three_Phase = 9,

		[Display(Name = "Mixed Phase")]
		[XmlEnum(Name = "Mixed Phase")]
		Mixed_Phase = 10,

		[Display(Name = "60 Amp Service")]
		[XmlEnum(Name = "60 Amp Service")]
		_60_Amp_Service = 11,

		[Display(Name = "120/208 V")]
		[XmlEnum(Name = "120/208 V")]
		_120_208_V = 12,

		[Display(Name = "347/600 V")]
		[XmlEnum(Name = "347/600 V")]
		_347_600_V = 13,

		[Display(Name = "Generator")]
		[XmlEnum(Name = "Generator")]
		Generator = 14,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 15,

		[Display(Name = "240/400V")]
		[XmlEnum(Name = "240/400V")]
		_240_400V = 16
    }
}