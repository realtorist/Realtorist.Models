using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum LandDispositionType
    {
		[Display(Name = "Fenced")]
		[XmlEnum(Name = "Fenced")]
		Fenced = 1,

		[Display(Name = "Cleared")]
		[XmlEnum(Name = "Cleared")]
		Cleared = 2,

		[Display(Name = "Pasture")]
		[XmlEnum(Name = "Pasture")]
		Pasture = 3,

		[Display(Name = "Tillable")]
		[XmlEnum(Name = "Tillable")]
		Tillable = 4,

		[Display(Name = "Tile Drained")]
		[XmlEnum(Name = "Tile Drained")]
		Tile_Drained = 5,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 6
    }
}