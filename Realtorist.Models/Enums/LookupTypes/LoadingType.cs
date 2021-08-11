using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum LoadingType
    {
		[Display(Name = "Truck level")]
		[XmlEnum(Name = "Truck level")]
		Truck_level = 1,

		[Display(Name = "Grade level")]
		[XmlEnum(Name = "Grade level")]
		Grade_level = 2,

		[Display(Name = "Rail siding")]
		[XmlEnum(Name = "Rail siding")]
		Rail_siding = 3,

		[Display(Name = "Freight Access")]
		[XmlEnum(Name = "Freight Access")]
		Freight_Access = 4,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 5,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 6
    }
}