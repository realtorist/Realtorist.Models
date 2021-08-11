using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum LeaseType
    {
		[Display(Name = "Gross")]
		[XmlEnum(Name = "Gross")]
		Gross = 1,

		[Display(Name = "Gross Escalating")]
		[XmlEnum(Name = "Gross Escalating")]
		Gross_Escalating = 2,

		[Display(Name = "Net")]
		[XmlEnum(Name = "Net")]
		Net = 3,

		[Display(Name = "Net Escalating")]
		[XmlEnum(Name = "Net Escalating")]
		Net_Escalating = 4,

		[Display(Name = "Triple Net")]
		[XmlEnum(Name = "Triple Net")]
		Triple_Net = 5,

		[Display(Name = "Percentage")]
		[XmlEnum(Name = "Percentage")]
		Percentage = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7,

		[Display(Name = "Net or Percentage")]
		[XmlEnum(Name = "Net or Percentage")]
		Net_or_Percentage = 8,

		[Display(Name = "Other, See Remarks")]
		[XmlEnum(Name = "Other, See Remarks")]
		Other_See_Remarks = 9,

		[Display(Name = "Semi-Gross")]
		[XmlEnum(Name = "Semi-Gross")]
		Semi_Gross = 10
    }
}