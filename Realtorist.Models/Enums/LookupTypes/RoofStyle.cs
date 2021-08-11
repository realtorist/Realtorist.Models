using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum RoofStyle
    {
		[Display(Name = "Conventional")]
		[XmlEnum(Name = "Conventional")]
		Conventional = 103,

		[Display(Name = "Peaked")]
		[XmlEnum(Name = "Peaked")]
		Peaked = 104,

		[Display(Name = "Flat")]
		[XmlEnum(Name = "Flat")]
		Flat = 102,

		[Display(Name = "Cottage")]
		[XmlEnum(Name = "Cottage")]
		Cottage = 105,

		[Display(Name = "Mansard")]
		[XmlEnum(Name = "Mansard")]
		Mansard = 101,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 106
    }
}