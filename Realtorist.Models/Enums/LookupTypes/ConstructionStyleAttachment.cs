using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ConstructionStyleAttachment
    {
		[Display(Name = "Detached")]
		[XmlEnum(Name = "Detached")]
		Detached = 3,

		[Display(Name = "Semi-detached")]
		[XmlEnum(Name = "Semi-detached")]
		Semi_detached = 5,

		[Display(Name = "Attached")]
		[XmlEnum(Name = "Attached")]
		Attached = 1,

		[Display(Name = "Front and back")]
		[XmlEnum(Name = "Front and back")]
		Front_and_back = 4,

		[Display(Name = "Side by side")]
		[XmlEnum(Name = "Side by side")]
		Side_by_side = 6,

		[Display(Name = "Up and down")]
		[XmlEnum(Name = "Up and down")]
		Up_and_down = 8,

		[Display(Name = "Stacked")]
		[XmlEnum(Name = "Stacked")]
		Stacked = 7,

		[Display(Name = "Link")]
		[XmlEnum(Name = "Link")]
		Link = 9,

		[Display(Name = "Strip mall")]
		[XmlEnum(Name = "Strip mall")]
		Strip_mall = 10,

		[Display(Name = "Shopping centre")]
		[XmlEnum(Name = "Shopping centre")]
		Shopping_centre = 11,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 12,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13
    }
}