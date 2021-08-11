using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum RoofMaterial
    {
		[Display(Name = "Asphalt shingle")]
		[XmlEnum(Name = "Asphalt shingle")]
		Asphalt_shingle = 1,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 24,

		[Display(Name = "Concrete")]
		[XmlEnum(Name = "Concrete")]
		Concrete = 23,

		[Display(Name = "Asphalt and Gravel")]
		[XmlEnum(Name = "Asphalt and Gravel")]
		Asphalt_and_Gravel = 22,

		[Display(Name = "Vinyl Shingles")]
		[XmlEnum(Name = "Vinyl Shingles")]
		Vinyl_Shingles = 20,

		[Display(Name = "Roll Roofing")]
		[XmlEnum(Name = "Roll Roofing")]
		Roll_Roofing = 18,

		[Display(Name = "Pine Shakes")]
		[XmlEnum(Name = "Pine Shakes")]
		Pine_Shakes = 17,

		[Display(Name = "Fiberglass")]
		[XmlEnum(Name = "Fiberglass")]
		Fiberglass = 16,

		[Display(Name = "Concrete Tile")]
		[XmlEnum(Name = "Concrete Tile")]
		Concrete_Tile = 15,

		[Display(Name = "Clay Tile")]
		[XmlEnum(Name = "Clay Tile")]
		Clay_Tile = 14,

		[Display(Name = "Metal")]
		[XmlEnum(Name = "Metal")]
		Metal = 11,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 10,

		[Display(Name = "Asphalt")]
		[XmlEnum(Name = "Asphalt")]
		Asphalt = 9,

		[Display(Name = "Tin")]
		[XmlEnum(Name = "Tin")]
		Tin = 8,

		[Display(Name = "Membrane")]
		[XmlEnum(Name = "Membrane")]
		Membrane = 7,

		[Display(Name = "Wood Shingle")]
		[XmlEnum(Name = "Wood Shingle")]
		Wood_Shingle = 6,

		[Display(Name = "Cedar shake")]
		[XmlEnum(Name = "Cedar shake")]
		Cedar_shake = 5,

		[Display(Name = "Tile")]
		[XmlEnum(Name = "Tile")]
		Tile = 4,

		[Display(Name = "Tar & gravel")]
		[XmlEnum(Name = "Tar & gravel")]
		Tar__gravel = 3,

		[Display(Name = "Steel")]
		[XmlEnum(Name = "Steel")]
		Steel = 2,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 25,

		[Display(Name = "Shakes")]
		[XmlEnum(Name = "Shakes")]
		Shakes = 27
    }
}