using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FireplaceType
    {
		[Display(Name = "Conventional")]
		[XmlEnum(Name = "Conventional")]
		Conventional = 5,

		[Display(Name = "Tile Facing")]
		[XmlEnum(Name = "Tile Facing")]
		Tile_Facing = 19,

		[Display(Name = "Stove")]
		[XmlEnum(Name = "Stove")]
		Stove = 18,

		[Display(Name = "Stone")]
		[XmlEnum(Name = "Stone")]
		Stone = 17,

		[Display(Name = "Roughed in")]
		[XmlEnum(Name = "Roughed in")]
		Roughed_in = 16,

		[Display(Name = "Other - See remarks")]
		[XmlEnum(Name = "Other - See remarks")]
		Other___See_remarks = 15,

		[Display(Name = "Marble fac")]
		[XmlEnum(Name = "Marble fac")]
		Marble_fac = 14,

		[Display(Name = "Heatilator/Fan")]
		[XmlEnum(Name = "Heatilator/Fan")]
		Heatilator_Fan = 13,

		[Display(Name = "Double-sided")]
		[XmlEnum(Name = "Double-sided")]
		Double_sided = 12,

		[Display(Name = "Direct vent")]
		[XmlEnum(Name = "Direct vent")]
		Direct_vent = 20,

		[Display(Name = "Corner")]
		[XmlEnum(Name = "Corner")]
		Corner = 11,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 9,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 8,

		[Display(Name = "Heatillator")]
		[XmlEnum(Name = "Heatillator")]
		Heatillator = 6,

		[Display(Name = "Rough In")]
		[XmlEnum(Name = "Rough In")]
		Rough_In = 4,

		[Display(Name = "Woodstove")]
		[XmlEnum(Name = "Woodstove")]
		Woodstove = 3,

		[Display(Name = "Insert")]
		[XmlEnum(Name = "Insert")]
		Insert = 2,

		[Display(Name = "Free Standing Metal")]
		[XmlEnum(Name = "Free Standing Metal")]
		Free_Standing_Metal = 1,

		[Display(Name = "Decorative")]
		[XmlEnum(Name = "Decorative")]
		Decorative = 7,

		[Display(Name = "Brick Facing")]
		[XmlEnum(Name = "Brick Facing")]
		Brick_Facing = 10,

		[Display(Name = "Glass Door")]
		[XmlEnum(Name = "Glass Door")]
		Glass_Door = 21
    }
}