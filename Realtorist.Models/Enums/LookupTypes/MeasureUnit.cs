using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum MeasureUnit
    {
		[Display(Name = "square feet")]
		[XmlEnum(Name = "square feet")]
		square_feet = 1,

		[Display(Name = "feet")]
		[XmlEnum(Name = "feet")]
		feet = 2,

		[Display(Name = "square meters")]
		[XmlEnum(Name = "square meters")]
		square_meters = 4,

		[Display(Name = "meters")]
		[XmlEnum(Name = "meters")]
		meters = 5,

		[Display(Name = "acres")]
		[XmlEnum(Name = "acres")]
		acres = 7,

		[Display(Name = "hectares")]
		[XmlEnum(Name = "hectares")]
		hectares = 10
    }
}