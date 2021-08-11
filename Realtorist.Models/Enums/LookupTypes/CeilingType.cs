using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum CeilingType
    {
		[Display(Name = "Suspended ceiling")]
		[XmlEnum(Name = "Suspended ceiling")]
		Suspended_ceiling = 1,

		[Display(Name = "Tile ceiling")]
		[XmlEnum(Name = "Tile ceiling")]
		Tile_ceiling = 2,

		[Display(Name = "Sheetrock (Drywall)")]
		[XmlEnum(Name = "Sheetrock (Drywall)")]
		Sheetrock_Drywall = 3,

		[Display(Name = "Plaster")]
		[XmlEnum(Name = "Plaster")]
		Plaster = 4,

		[Display(Name = "Vaulted")]
		[XmlEnum(Name = "Vaulted")]
		Vaulted = 5,

		[Display(Name = "Cathedral")]
		[XmlEnum(Name = "Cathedral")]
		Cathedral = 6,

		[Display(Name = "Domed")]
		[XmlEnum(Name = "Domed")]
		Domed = 7,

		[Display(Name = "Open")]
		[XmlEnum(Name = "Open")]
		Open = 8,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 9
    }
}