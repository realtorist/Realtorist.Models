using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum UtilityType
    {
		[Display(Name = "Water")]
		[XmlEnum(Name = "Water")]
		Water = 1,

		[Display(Name = "Sewer")]
		[XmlEnum(Name = "Sewer")]
		Sewer = 2,

		[Display(Name = "Natural Gas")]
		[XmlEnum(Name = "Natural Gas")]
		Natural_Gas = 3,

		[Display(Name = "Electricity")]
		[XmlEnum(Name = "Electricity")]
		Electricity = 4,

		[Display(Name = "Cable")]
		[XmlEnum(Name = "Cable")]
		Cable = 5,

		[Display(Name = "Telephone")]
		[XmlEnum(Name = "Telephone")]
		Telephone = 6,

		[Display(Name = "DSL*")]
		[XmlEnum(Name = "DSL*")]
		DSL = 7,

		[Display(Name = "Wireless")]
		[XmlEnum(Name = "Wireless")]
		Wireless = 8,

		[Display(Name = "Fully serviced")]
		[XmlEnum(Name = "Fully serviced")]
		Fully_serviced = 9,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 10
    }
}