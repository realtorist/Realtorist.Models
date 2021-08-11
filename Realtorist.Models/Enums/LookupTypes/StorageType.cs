using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum StorageType
    {
		[Display(Name = "Locker")]
		[XmlEnum(Name = "Locker")]
		Locker = 1,

		[Display(Name = "Storage Shed")]
		[XmlEnum(Name = "Storage Shed")]
		Storage_Shed = 2,

		[Display(Name = "Holding Tank")]
		[XmlEnum(Name = "Holding Tank")]
		Holding_Tank = 3,

		[Display(Name = "Outside Storage")]
		[XmlEnum(Name = "Outside Storage")]
		Outside_Storage = 4,

		[Display(Name = "Storage")]
		[XmlEnum(Name = "Storage")]
		Storage = 5,

		[Display(Name = "Storage in Basement")]
		[XmlEnum(Name = "Storage in Basement")]
		Storage_in_Basement = 6,

		[Display(Name = "Silo")]
		[XmlEnum(Name = "Silo")]
		Silo = 7,

		[Display(Name = "Feed Storage")]
		[XmlEnum(Name = "Feed Storage")]
		Feed_Storage = 8,

		[Display(Name = "Liquid Holding Tank")]
		[XmlEnum(Name = "Liquid Holding Tank")]
		Liquid_Holding_Tank = 9,

		[Display(Name = "Dry Holding Tank")]
		[XmlEnum(Name = "Dry Holding Tank")]
		Dry_Holding_Tank = 10,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 11,

		[Display(Name = "Manure Pit")]
		[XmlEnum(Name = "Manure Pit")]
		Manure_Pit = 12,

		[Display(Name = "Unit")]
		[XmlEnum(Name = "Unit")]
		Unit = 13
    }
}