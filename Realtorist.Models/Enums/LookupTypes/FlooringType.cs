using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FlooringType
    {
		[Display(Name = "Concrete")]
		[XmlEnum(Name = "Concrete")]
		Concrete = 1,

		[Display(Name = "Cushion/Lino/Vinyl")]
		[XmlEnum(Name = "Cushion/Lino/Vinyl")]
		Cushion_Lino_Vinyl = 30,

		[Display(Name = "Ceramic/Porcelain")]
		[XmlEnum(Name = "Ceramic/Porcelain")]
		Ceramic_Porcelain = 29,

		[Display(Name = "Bamboo")]
		[XmlEnum(Name = "Bamboo")]
		Bamboo = 28,

		[Display(Name = "Concrete Slab")]
		[XmlEnum(Name = "Concrete Slab")]
		Concrete_Slab = 27,

		[Display(Name = "Mixed Flooring")]
		[XmlEnum(Name = "Mixed Flooring")]
		Mixed_Flooring = 26,

		[Display(Name = "Carpet over Hardwood")]
		[XmlEnum(Name = "Carpet over Hardwood")]
		Carpet_over_Hardwood = 25,

		[Display(Name = "Wall-to-wall carpet")]
		[XmlEnum(Name = "Wall-to-wall carpet")]
		Wall_to_wall_carpet = 24,

		[Display(Name = "Porcelain Tile")]
		[XmlEnum(Name = "Porcelain Tile")]
		Porcelain_Tile = 23,

		[Display(Name = "Cork")]
		[XmlEnum(Name = "Cork")]
		Cork = 22,

		[Display(Name = "Wood")]
		[XmlEnum(Name = "Wood")]
		Wood = 21,

		[Display(Name = "Vinyl Tile")]
		[XmlEnum(Name = "Vinyl Tile")]
		Vinyl_Tile = 20,

		[Display(Name = "Vinyl")]
		[XmlEnum(Name = "Vinyl")]
		Vinyl = 19,

		[Display(Name = "Linoleum")]
		[XmlEnum(Name = "Linoleum")]
		Linoleum = 18,

		[Display(Name = "Ceramic Tile")]
		[XmlEnum(Name = "Ceramic Tile")]
		Ceramic_Tile = 17,

		[Display(Name = "Floating")]
		[XmlEnum(Name = "Floating")]
		Floating = 16,

		[Display(Name = "Ceramic")]
		[XmlEnum(Name = "Ceramic")]
		Ceramic = 15,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 14,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 13,

		[Display(Name = "Heavy loading")]
		[XmlEnum(Name = "Heavy loading")]
		Heavy_loading = 12,

		[Display(Name = "Carpet tiles")]
		[XmlEnum(Name = "Carpet tiles")]
		Carpet_tiles = 11,

		[Display(Name = "Stone")]
		[XmlEnum(Name = "Stone")]
		Stone = 10,

		[Display(Name = "Engineered hardwood")]
		[XmlEnum(Name = "Engineered hardwood")]
		Engineered_hardwood = 9,

		[Display(Name = "Carpeted")]
		[XmlEnum(Name = "Carpeted")]
		Carpeted = 8,

		[Display(Name = "Parquet")]
		[XmlEnum(Name = "Parquet")]
		Parquet = 7,

		[Display(Name = "Marble")]
		[XmlEnum(Name = "Marble")]
		Marble = 6,

		[Display(Name = "Slate")]
		[XmlEnum(Name = "Slate")]
		Slate = 5,

		[Display(Name = "Laminate")]
		[XmlEnum(Name = "Laminate")]
		Laminate = 4,

		[Display(Name = "Hardwood")]
		[XmlEnum(Name = "Hardwood")]
		Hardwood = 3,

		[Display(Name = "Tile")]
		[XmlEnum(Name = "Tile")]
		Tile = 2,

		[Display(Name = "Marble/Granite/Quartz")]
		[XmlEnum(Name = "Marble/Granite/Quartz")]
		Marble_Granite_Quartz = 32,

		[Display(Name = "Softwood")]
		[XmlEnum(Name = "Softwood")]
		Softwood = 33
    }
}