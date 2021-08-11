using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ConstructionMaterial
    {
		[Display(Name = "Insulbrick")]
		[XmlEnum(Name = "Insulbrick")]
		Insulbrick = 1,

		[Display(Name = "Poured concrete")]
		[XmlEnum(Name = "Poured concrete")]
		Poured_concrete = 2,

		[Display(Name = "Straw bales")]
		[XmlEnum(Name = "Straw bales")]
		Straw_bales = 3,

		[Display(Name = "Wood frame")]
		[XmlEnum(Name = "Wood frame")]
		Wood_frame = 4,

		[Display(Name = "Concrete block")]
		[XmlEnum(Name = "Concrete block")]
		Concrete_block = 5,

		[Display(Name = "Masonry")]
		[XmlEnum(Name = "Masonry")]
		Masonry = 6,

		[Display(Name = "Steel frame")]
		[XmlEnum(Name = "Steel frame")]
		Steel_frame = 7,

		[Display(Name = "Log")]
		[XmlEnum(Name = "Log")]
		Log = 8,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 9,

		[Display(Name = "ICF Block")]
		[XmlEnum(Name = "ICF Block")]
		ICF_Block = 10,

		[Display(Name = "Concrete Walls")]
		[XmlEnum(Name = "Concrete Walls")]
		Concrete_Walls = 11
    }
}