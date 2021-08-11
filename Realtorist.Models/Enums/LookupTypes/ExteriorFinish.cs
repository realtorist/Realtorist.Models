using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ExteriorFinish
    {
		[Display(Name = "Steel")]
		[XmlEnum(Name = "Steel")]
		Steel = 1,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 25,

		[Display(Name = "Cedar Siding")]
		[XmlEnum(Name = "Cedar Siding")]
		Cedar_Siding = 26,

		[Display(Name = "Log Siding")]
		[XmlEnum(Name = "Log Siding")]
		Log_Siding = 27,

		[Display(Name = "Metal")]
		[XmlEnum(Name = "Metal")]
		Metal = 28,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 29,

		[Display(Name = "Log")]
		[XmlEnum(Name = "Log")]
		Log = 30,

		[Display(Name = "Siding")]
		[XmlEnum(Name = "Siding")]
		Siding = 31,

		[Display(Name = "Composite Siding")]
		[XmlEnum(Name = "Composite Siding")]
		Composite_Siding = 32,

		[Display(Name = "Aluminum trim")]
		[XmlEnum(Name = "Aluminum trim")]
		Aluminum_trim = 24,

		[Display(Name = "Colour Loc")]
		[XmlEnum(Name = "Colour Loc")]
		Colour_Loc = 33,

		[Display(Name = "Concrete Siding")]
		[XmlEnum(Name = "Concrete Siding")]
		Concrete_Siding = 35,

		[Display(Name = "Insul Brick")]
		[XmlEnum(Name = "Insul Brick")]
		Insul_Brick = 36,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 37,

		[Display(Name = "Brick Facing")]
		[XmlEnum(Name = "Brick Facing")]
		Brick_Facing = 38,

		[Display(Name = "Aluminum")]
		[XmlEnum(Name = "Aluminum")]
		Aluminum = 39,

		[Display(Name = "Aluminum/Vinyl")]
		[XmlEnum(Name = "Aluminum/Vinyl")]
		Aluminum_Vinyl = 40,

		[Display(Name = "Concrete/Stucco")]
		[XmlEnum(Name = "Concrete/Stucco")]
		Concrete_Stucco = 41,

		[Display(Name = "Masonite")]
		[XmlEnum(Name = "Masonite")]
		Masonite = 42,

		[Display(Name = "Concrete Block")]
		[XmlEnum(Name = "Concrete Block")]
		Concrete_Block = 34,

		[Display(Name = "Vinyl siding")]
		[XmlEnum(Name = "Vinyl siding")]
		Vinyl_siding = 23,

		[Display(Name = "Wood siding")]
		[XmlEnum(Name = "Wood siding")]
		Wood_siding = 22,

		[Display(Name = "Precast concrete")]
		[XmlEnum(Name = "Precast concrete")]
		Precast_concrete = 21,

		[Display(Name = "Aggregate")]
		[XmlEnum(Name = "Aggregate")]
		Aggregate = 2,

		[Display(Name = "Asbestos")]
		[XmlEnum(Name = "Asbestos")]
		Asbestos = 3,

		[Display(Name = "Asphalt")]
		[XmlEnum(Name = "Asphalt")]
		Asphalt = 4,

		[Display(Name = "Cedar shingles")]
		[XmlEnum(Name = "Cedar shingles")]
		Cedar_shingles = 5,

		[Display(Name = "Concrete")]
		[XmlEnum(Name = "Concrete")]
		Concrete = 6,

		[Display(Name = "Wood")]
		[XmlEnum(Name = "Wood")]
		Wood = 7,

		[Display(Name = "Wood shingles")]
		[XmlEnum(Name = "Wood shingles")]
		Wood_shingles = 8,

		[Display(Name = "Brick")]
		[XmlEnum(Name = "Brick")]
		Brick = 9,

		[Display(Name = "Cedar covering joint")]
		[XmlEnum(Name = "Cedar covering joint")]
		Cedar_covering_joint = 10,

		[Display(Name = "Pressed fibre")]
		[XmlEnum(Name = "Pressed fibre")]
		Pressed_fibre = 11,

		[Display(Name = "Sheathing brick paper")]
		[XmlEnum(Name = "Sheathing brick paper")]
		Sheathing_brick_paper = 12,

		[Display(Name = "Stone")]
		[XmlEnum(Name = "Stone")]
		Stone = 13,

		[Display(Name = "Brick imitation")]
		[XmlEnum(Name = "Brick imitation")]
		Brick_imitation = 14,

		[Display(Name = "Rock imitation")]
		[XmlEnum(Name = "Rock imitation")]
		Rock_imitation = 15,

		[Display(Name = "Stucco")]
		[XmlEnum(Name = "Stucco")]
		Stucco = 16,

		[Display(Name = "Vinyl")]
		[XmlEnum(Name = "Vinyl")]
		Vinyl = 17,

		[Display(Name = "Aluminum siding")]
		[XmlEnum(Name = "Aluminum siding")]
		Aluminum_siding = 18,

		[Display(Name = "Glass")]
		[XmlEnum(Name = "Glass")]
		Glass = 19,

		[Display(Name = "Hardboard")]
		[XmlEnum(Name = "Hardboard")]
		Hardboard = 20,

		[Display(Name = "Shingles")]
		[XmlEnum(Name = "Shingles")]
		Shingles = 43,

		[Display(Name = "Engineered Wood Siding")]
		[XmlEnum(Name = "Engineered Wood Siding")]
		Engineered_Wood_Siding = 44
    }
}