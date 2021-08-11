using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FoundationType
    {
		[Display(Name = "Wood")]
		[XmlEnum(Name = "Wood")]
		Wood = 1,

		[Display(Name = "Slab")]
		[XmlEnum(Name = "Slab")]
		Slab = 15,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 14,

		[Display(Name = "Pillars & Posts")]
		[XmlEnum(Name = "Pillars & Posts")]
		Pillars__Posts = 13,

		[Display(Name = "Brick/Stone")]
		[XmlEnum(Name = "Brick/Stone")]
		Brick_Stone = 12,

		[Display(Name = "Brick")]
		[XmlEnum(Name = "Brick")]
		Brick = 11,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 10,

		[Display(Name = "Wood/Piers")]
		[XmlEnum(Name = "Wood/Piers")]
		Wood_Piers = 16,

		[Display(Name = "Poured Concrete")]
		[XmlEnum(Name = "Poured Concrete")]
		Poured_Concrete = 9,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7,

		[Display(Name = "Piled")]
		[XmlEnum(Name = "Piled")]
		Piled = 6,

		[Display(Name = "Concrete Slab")]
		[XmlEnum(Name = "Concrete Slab")]
		Concrete_Slab = 5,

		[Display(Name = "Concrete Perimeter")]
		[XmlEnum(Name = "Concrete Perimeter")]
		Concrete_Perimeter = 4,

		[Display(Name = "Block")]
		[XmlEnum(Name = "Block")]
		Block = 3,

		[Display(Name = "Stone")]
		[XmlEnum(Name = "Stone")]
		Stone = 2,

		[Display(Name = "Concrete")]
		[XmlEnum(Name = "Concrete")]
		Concrete = 8,

		[Display(Name = "Concrete Block")]
		[XmlEnum(Name = "Concrete Block")]
		Concrete_Block = 17
    }
}