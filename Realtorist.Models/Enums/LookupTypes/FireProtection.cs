using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum FireProtection
    {
		[Display(Name = "Alarm system")]
		[XmlEnum(Name = "Alarm system")]
		Alarm_system = 1,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 15,

		[Display(Name = "No Sprinkler System")]
		[XmlEnum(Name = "No Sprinkler System")]
		No_Sprinkler_System = 14,

		[Display(Name = "Full Sprinkler System")]
		[XmlEnum(Name = "Full Sprinkler System")]
		Full_Sprinkler_System = 13,

		[Display(Name = "Security Window Bars")]
		[XmlEnum(Name = "Security Window Bars")]
		Security_Window_Bars = 12,

		[Display(Name = "Monitored Alarm")]
		[XmlEnum(Name = "Monitored Alarm")]
		Monitored_Alarm = 11,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 10,

		[Display(Name = "Partial Sprinkler System")]
		[XmlEnum(Name = "Partial Sprinkler System")]
		Partial_Sprinkler_System = 16,

		[Display(Name = "Fire alarm system")]
		[XmlEnum(Name = "Fire alarm system")]
		Fire_alarm_system = 9,

		[Display(Name = "Sprinkler System-Fire")]
		[XmlEnum(Name = "Sprinkler System-Fire")]
		Sprinkler_System_Fire = 7,

		[Display(Name = "Smoke Detectors")]
		[XmlEnum(Name = "Smoke Detectors")]
		Smoke_Detectors = 6,

		[Display(Name = "Split security(man/electric)")]
		[XmlEnum(Name = "Split security(man/electric)")]
		Split_securityman_electric = 5,

		[Display(Name = "Security")]
		[XmlEnum(Name = "Security")]
		Security = 4,

		[Display(Name = "Security guard")]
		[XmlEnum(Name = "Security guard")]
		Security_guard = 3,

		[Display(Name = "Security system")]
		[XmlEnum(Name = "Security system")]
		Security_system = 2,

		[Display(Name = "Controlled entry")]
		[XmlEnum(Name = "Controlled entry")]
		Controlled_entry = 8,

		[Display(Name = "Smoke Detector Only")]
		[XmlEnum(Name = "Smoke Detector Only")]
		Smoke_Detector_Only = 17
    }
}