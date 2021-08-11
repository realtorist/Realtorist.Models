using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum RightType
    {
		[Display(Name = "Water Rights")]
		[XmlEnum(Name = "Water Rights")]
		Water_Rights = 2,

		[Display(Name = "Mineral Rights")]
		[XmlEnum(Name = "Mineral Rights")]
		Mineral_Rights = 3,

		[Display(Name = "Timber Rights")]
		[XmlEnum(Name = "Timber Rights")]
		Timber_Rights = 4,

		[Display(Name = "Grazing Rights")]
		[XmlEnum(Name = "Grazing Rights")]
		Grazing_Rights = 5,

		[Display(Name = "Beach Rights")]
		[XmlEnum(Name = "Beach Rights")]
		Beach_Rights = 6,

		[Display(Name = "Foreshore Rights")]
		[XmlEnum(Name = "Foreshore Rights")]
		Foreshore_Rights = 7,

		[Display(Name = "Air Rights")]
		[XmlEnum(Name = "Air Rights")]
		Air_Rights = 8,

		[Display(Name = "Riparian Rights")]
		[XmlEnum(Name = "Riparian Rights")]
		Riparian_Rights = 9,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 10
    }
}