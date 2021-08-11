using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum SoilType
    {
		[Display(Name = "Clay")]
		[XmlEnum(Name = "Clay")]
		Clay = 1,

		[Display(Name = "Wet")]
		[XmlEnum(Name = "Wet")]
		Wet = 17,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 16,

		[Display(Name = "Sandy Beach")]
		[XmlEnum(Name = "Sandy Beach")]
		Sandy_Beach = 15,

		[Display(Name = "Rocky")]
		[XmlEnum(Name = "Rocky")]
		Rocky = 14,

		[Display(Name = "Otonabee Loam")]
		[XmlEnum(Name = "Otonabee Loam")]
		Otonabee_Loam = 13,

		[Display(Name = "Light")]
		[XmlEnum(Name = "Light")]
		Light = 12,

		[Display(Name = "Heavy")]
		[XmlEnum(Name = "Heavy")]
		Heavy = 11,

		[Display(Name = "Sand")]
		[XmlEnum(Name = "Sand")]
		Sand = 18,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 10,

		[Display(Name = "Loam")]
		[XmlEnum(Name = "Loam")]
		Loam = 8,

		[Display(Name = "Stony")]
		[XmlEnum(Name = "Stony")]
		Stony = 7,

		[Display(Name = "Stones")]
		[XmlEnum(Name = "Stones")]
		Stones = 6,

		[Display(Name = "Some stones")]
		[XmlEnum(Name = "Some stones")]
		Some_stones = 5,

		[Display(Name = "Sand/gravel")]
		[XmlEnum(Name = "Sand/gravel")]
		Sand_gravel = 4,

		[Display(Name = "No stones")]
		[XmlEnum(Name = "No stones")]
		No_stones = 3,

		[Display(Name = "Mixed soil")]
		[XmlEnum(Name = "Mixed soil")]
		Mixed_soil = 2,

		[Display(Name = "Peat")]
		[XmlEnum(Name = "Peat")]
		Peat = 9,

		[Display(Name = "Gravel")]
		[XmlEnum(Name = "Gravel")]
		Gravel = 19
    }
}