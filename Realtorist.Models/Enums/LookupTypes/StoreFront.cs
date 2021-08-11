using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum StoreFront
    {
		[Display(Name = "Interior Storefront")]
		[XmlEnum(Name = "Interior Storefront")]
		Interior_Storefront = 1,

		[Display(Name = "Exterior Storefront")]
		[XmlEnum(Name = "Exterior Storefront")]
		Exterior_Storefront = 2,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 3
    }
}