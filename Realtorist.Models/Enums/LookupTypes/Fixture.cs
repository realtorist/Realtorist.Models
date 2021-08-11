using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Fixture
    {
		[Display(Name = "All")]
		[XmlEnum(Name = "All")]
		All = 1,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 2,

		[Display(Name = "Ceiling fans")]
		[XmlEnum(Name = "Ceiling fans")]
		Ceiling_fans = 3,

		[Display(Name = "Drapes/Window coverings")]
		[XmlEnum(Name = "Drapes/Window coverings")]
		Drapes_Window_coverings = 4,

		[Display(Name = "Venetian blinds")]
		[XmlEnum(Name = "Venetian blinds")]
		Venetian_blinds = 5,

		[Display(Name = "TV Antenna")]
		[XmlEnum(Name = "TV Antenna")]
		TV_Antenna = 6,

		[Display(Name = "Chandelier")]
		[XmlEnum(Name = "Chandelier")]
		Chandelier = 7,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 8,

		[Display(Name = "List of Fixtures Available")]
		[XmlEnum(Name = "List of Fixtures Available")]
		List_of_Fixtures_Available = 9
    }
}