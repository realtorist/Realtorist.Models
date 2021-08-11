using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum UtilityWater
    {
		[Display(Name = "Municipal water")]
		[XmlEnum(Name = "Municipal water")]
		Municipal_water = 1,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 24,

		[Display(Name = "Hand Pump")]
		[XmlEnum(Name = "Hand Pump")]
		Hand_Pump = 23,

		[Display(Name = "Dugout")]
		[XmlEnum(Name = "Dugout")]
		Dugout = 22,

		[Display(Name = "Government Managed")]
		[XmlEnum(Name = "Government Managed")]
		Government_Managed = 21,

		[Display(Name = "Licensed")]
		[XmlEnum(Name = "Licensed")]
		Licensed = 20,

		[Display(Name = "Community Water User's Utility")]
		[XmlEnum(Name = "Community Water User's Utility")]
		Community_Water_Users_Utility = 19,

		[Display(Name = "Spring")]
		[XmlEnum(Name = "Spring")]
		Spring = 18,

		[Display(Name = "Creek/Stream")]
		[XmlEnum(Name = "Creek/Stream")]
		Creek_Stream = 17,

		[Display(Name = "Community Water System")]
		[XmlEnum(Name = "Community Water System")]
		Community_Water_System = 16,

		[Display(Name = "Well")]
		[XmlEnum(Name = "Well")]
		Well = 15,

		[Display(Name = "Irrigation District")]
		[XmlEnum(Name = "Irrigation District")]
		Irrigation_District = 14,

		[Display(Name = "Private Utility")]
		[XmlEnum(Name = "Private Utility")]
		Private_Utility = 13,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 12,

		[Display(Name = "Sand point")]
		[XmlEnum(Name = "Sand point")]
		Sand_point = 11,

		[Display(Name = "Co-operative Well")]
		[XmlEnum(Name = "Co-operative Well")]
		Co_operative_Well = 10,

		[Display(Name = "Bored Well")]
		[XmlEnum(Name = "Bored Well")]
		Bored_Well = 9,

		[Display(Name = "Dug Well")]
		[XmlEnum(Name = "Dug Well")]
		Dug_Well = 8,

		[Display(Name = "Lake/River Water Intake")]
		[XmlEnum(Name = "Lake/River Water Intake")]
		Lake_River_Water_Intake = 7,

		[Display(Name = "Shared Well")]
		[XmlEnum(Name = "Shared Well")]
		Shared_Well = 6,

		[Display(Name = "Drilled Well")]
		[XmlEnum(Name = "Drilled Well")]
		Drilled_Well = 5,

		[Display(Name = "Cistern")]
		[XmlEnum(Name = "Cistern")]
		Cistern = 4,

		[Display(Name = "City water")]
		[XmlEnum(Name = "City water")]
		City_water = 3,

		[Display(Name = "Ground-level well")]
		[XmlEnum(Name = "Ground-level well")]
		Ground_level_well = 2,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 25,

		[Display(Name = "Artesian Well")]
		[XmlEnum(Name = "Artesian Well")]
		Artesian_Well = 26
    }
}