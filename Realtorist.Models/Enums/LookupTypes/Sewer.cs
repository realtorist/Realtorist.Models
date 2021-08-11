using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Sewer
    {
		[Display(Name = "No sewage system")]
		[XmlEnum(Name = "No sewage system")]
		No_sewage_system = 1,

		[Display(Name = "Pump")]
		[XmlEnum(Name = "Pump")]
		Pump = 18,

		[Display(Name = "See remarks")]
		[XmlEnum(Name = "See remarks")]
		See_remarks = 17,

		[Display(Name = "Mound")]
		[XmlEnum(Name = "Mound")]
		Mound = 16,

		[Display(Name = "Gravity")]
		[XmlEnum(Name = "Gravity")]
		Gravity = 14,

		[Display(Name = "Ejector System")]
		[XmlEnum(Name = "Ejector System")]
		Ejector_System = 13,

		[Display(Name = "Septic Tank and Field")]
		[XmlEnum(Name = "Septic Tank and Field")]
		Septic_Tank_and_Field = 12,

		[Display(Name = "Holding Tank")]
		[XmlEnum(Name = "Holding Tank")]
		Holding_Tank = 11,

		[Display(Name = "Facultative Lagoon")]
		[XmlEnum(Name = "Facultative Lagoon")]
		Facultative_Lagoon = 19,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 10,

		[Display(Name = "Septic System")]
		[XmlEnum(Name = "Septic System")]
		Septic_System = 8,

		[Display(Name = "Sealed septic tank")]
		[XmlEnum(Name = "Sealed septic tank")]
		Sealed_septic_tank = 7,

		[Display(Name = "Septic tank")]
		[XmlEnum(Name = "Septic tank")]
		Septic_tank = 6,

		[Display(Name = "Septic tank without purification field")]
		[XmlEnum(Name = "Septic tank without purification field")]
		Septic_tank_without_purification_field = 5,

		[Display(Name = "Storm sewer")]
		[XmlEnum(Name = "Storm sewer")]
		Storm_sewer = 4,

		[Display(Name = "Sanitary sewer")]
		[XmlEnum(Name = "Sanitary sewer")]
		Sanitary_sewer = 3,

		[Display(Name = "Municipal sewage system")]
		[XmlEnum(Name = "Municipal sewage system")]
		Municipal_sewage_system = 2,

		[Display(Name = "Private sewer")]
		[XmlEnum(Name = "Private sewer")]
		Private_sewer = 9,

		[Display(Name = "Septic Field")]
		[XmlEnum(Name = "Septic Field")]
		Septic_Field = 20
    }
}