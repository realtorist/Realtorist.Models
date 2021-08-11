using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Easement
    {
		[Display(Name = "Sub Division Covenants")]
		[XmlEnum(Name = "Sub Division Covenants")]
		Sub_Division_Covenants = 1,

		[Display(Name = "Leased")]
		[XmlEnum(Name = "Leased")]
		Leased = 15,

		[Display(Name = "By-Law Restriction")]
		[XmlEnum(Name = "By-Law Restriction")]
		By_Law_Restriction = 14,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 12,

		[Display(Name = "See Site plan")]
		[XmlEnum(Name = "See Site plan")]
		See_Site_plan = 11,

		[Display(Name = "Escarpment Control")]
		[XmlEnum(Name = "Escarpment Control")]
		Escarpment_Control = 10,

		[Display(Name = "Oil/Gas/Mineral Rights")]
		[XmlEnum(Name = "Oil/Gas/Mineral Rights")]
		Oil_Gas_Mineral_Rights = 16,

		[Display(Name = "Encroachment")]
		[XmlEnum(Name = "Encroachment")]
		Encroachment = 9,

		[Display(Name = "Surface Right of Way")]
		[XmlEnum(Name = "Surface Right of Way")]
		Surface_Right_of_Way = 7,

		[Display(Name = "Overhead Right of Way")]
		[XmlEnum(Name = "Overhead Right of Way")]
		Overhead_Right_of_Way = 6,

		[Display(Name = "Environment protected")]
		[XmlEnum(Name = "Environment protected")]
		Environment_protected = 5,

		[Display(Name = "Flood Plain")]
		[XmlEnum(Name = "Flood Plain")]
		Flood_Plain = 4,

		[Display(Name = "Right of way")]
		[XmlEnum(Name = "Right of way")]
		Right_of_way = 3,

		[Display(Name = "Easement")]
		[XmlEnum(Name = "Easement")]
		Easement = 2,

		[Display(Name = "Underground Right of Way")]
		[XmlEnum(Name = "Underground Right of Way")]
		Underground_Right_of_Way = 8,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 17
    }
}