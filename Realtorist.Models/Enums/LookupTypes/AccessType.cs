using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum AccessType
    {
		[Display(Name = "Easy access")]
		[XmlEnum(Name = "Easy access")]
		Easy_access = 1,

		[Display(Name = "Marina Docking")]
		[XmlEnum(Name = "Marina Docking")]
		Marina_Docking = 20,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 19,

		[Display(Name = "Public Road")]
		[XmlEnum(Name = "Public Road")]
		Public_Road = 18,

		[Display(Name = "Private Road")]
		[XmlEnum(Name = "Private Road")]
		Private_Road = 17,

		[Display(Name = "Ferry Access")]
		[XmlEnum(Name = "Ferry Access")]
		Ferry_Access = 16,

		[Display(Name = "Highway Nearby")]
		[XmlEnum(Name = "Highway Nearby")]
		Highway_Nearby = 15,

		[Display(Name = "Allowed Access")]
		[XmlEnum(Name = "Allowed Access")]
		Allowed_Access = 14,

		[Display(Name = "Front & Rear Drive Access")]
		[XmlEnum(Name = "Front & Rear Drive Access")]
		Front__Rear_Drive_Access = 13,

		[Display(Name = "Private Docking")]
		[XmlEnum(Name = "Private Docking")]
		Private_Docking = 21,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 12,

		[Display(Name = "Road access")]
		[XmlEnum(Name = "Road access")]
		Road_access = 10,

		[Display(Name = "Water access")]
		[XmlEnum(Name = "Water access")]
		Water_access = 9,

		[Display(Name = "River access")]
		[XmlEnum(Name = "River access")]
		River_access = 8,

		[Display(Name = "Year-round access")]
		[XmlEnum(Name = "Year-round access")]
		Year_round_access = 7,

		[Display(Name = "Right-of-way")]
		[XmlEnum(Name = "Right-of-way")]
		Right_of_way = 6,

		[Display(Name = "Boat access")]
		[XmlEnum(Name = "Boat access")]
		Boat_access = 4,

		[Display(Name = "Rail access")]
		[XmlEnum(Name = "Rail access")]
		Rail_access = 3,

		[Display(Name = "Highway access")]
		[XmlEnum(Name = "Highway access")]
		Highway_access = 2,

		[Display(Name = "No access")]
		[XmlEnum(Name = "No access")]
		No_access = 11,

		[Display(Name = "Public Docking")]
		[XmlEnum(Name = "Public Docking")]
		Public_Docking = 22
    }
}