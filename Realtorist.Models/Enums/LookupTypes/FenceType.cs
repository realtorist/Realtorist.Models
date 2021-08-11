using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FenceType
    {
		[Display(Name = "Fence")]
		[XmlEnum(Name = "Fence")]
		Fence = 1,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 16,

		[Display(Name = "")]
		[XmlEnum(Name = "")]
		None = 15,

		[Display(Name = "Electric")]
		[XmlEnum(Name = "Electric")]
		Electric = 14,

		[Display(Name = "Privacy")]
		[XmlEnum(Name = "Privacy")]
		Privacy = 13,

		[Display(Name = "Wrought iron")]
		[XmlEnum(Name = "Wrought iron")]
		Wrought_iron = 12,

		[Display(Name = "Chain link")]
		[XmlEnum(Name = "Chain link")]
		Chain_link = 11,

		[Display(Name = "Board")]
		[XmlEnum(Name = "Board")]
		Board = 10,

		[Display(Name = "Cedar rail")]
		[XmlEnum(Name = "Cedar rail")]
		Cedar_rail = 9,

		[Display(Name = "Rail")]
		[XmlEnum(Name = "Rail")]
		Rail = 8,

		[Display(Name = "Page Wire")]
		[XmlEnum(Name = "Page Wire")]
		Page_Wire = 7,

		[Display(Name = "Barbed Wire")]
		[XmlEnum(Name = "Barbed Wire")]
		Barbed_Wire = 6,

		[Display(Name = "Cross fenced")]
		[XmlEnum(Name = "Cross fenced")]
		Cross_fenced = 5,

		[Display(Name = "Fenced yard")]
		[XmlEnum(Name = "Fenced yard")]
		Fenced_yard = 4,

		[Display(Name = "Partially fenced")]
		[XmlEnum(Name = "Partially fenced")]
		Partially_fenced = 3,

		[Display(Name = "Not fenced")]
		[XmlEnum(Name = "Not fenced")]
		Not_fenced = 2,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 17,

		[Display(Name = "Fully Fenced")]
		[XmlEnum(Name = "Fully Fenced")]
		Fully_Fenced = 18
    }
}