using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FarmType
    {
		[Display(Name = "Animal")]
		[XmlEnum(Name = "Animal")]
		Animal = 1,

		[Display(Name = "Boarding")]
		[XmlEnum(Name = "Boarding")]
		Boarding = 2,

		[Display(Name = "Cash Crop")]
		[XmlEnum(Name = "Cash Crop")]
		Cash_Crop = 3,

		[Display(Name = "Feed Lot")]
		[XmlEnum(Name = "Feed Lot")]
		Feed_Lot = 4,

		[Display(Name = "Nursery")]
		[XmlEnum(Name = "Nursery")]
		Nursery = 5,

		[Display(Name = "Market Gardening")]
		[XmlEnum(Name = "Market Gardening")]
		Market_Gardening = 6,

		[Display(Name = "Hobby Farm")]
		[XmlEnum(Name = "Hobby Farm")]
		Hobby_Farm = 7,

		[Display(Name = "Vineyard")]
		[XmlEnum(Name = "Vineyard")]
		Vineyard = 8,

		[Display(Name = "Orchard")]
		[XmlEnum(Name = "Orchard")]
		Orchard = 9,

		[Display(Name = "Greenhouse")]
		[XmlEnum(Name = "Greenhouse")]
		Greenhouse = 10,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 11,

		[Display(Name = "Mixed")]
		[XmlEnum(Name = "Mixed")]
		Mixed = 12,

		[Display(Name = "Farm")]
		[XmlEnum(Name = "Farm")]
		Farm = 13,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 14,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 15,

		[Display(Name = "Packing Building")]
		[XmlEnum(Name = "Packing Building")]
		Packing_Building = 16
    }
}