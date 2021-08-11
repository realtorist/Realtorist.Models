using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum PropertyType
    {
		[Display(Name = "Single Family")]
		[XmlEnum(Name = "Single Family")]
		Single_Family = 300,

		[Display(Name = "Recreational")]
		[XmlEnum(Name = "Recreational")]
		Recreational = 301,

		[Display(Name = "Agriculture")]
		[XmlEnum(Name = "Agriculture")]
		Agriculture = 302,

		[Display(Name = "Vacant Land")]
		[XmlEnum(Name = "Vacant Land")]
		Vacant_Land = 303,

		[Display(Name = "Office")]
		[XmlEnum(Name = "Office")]
		Office = 304,

		[Display(Name = "Retail")]
		[XmlEnum(Name = "Retail")]
		Retail = 305,

		[Display(Name = "Business")]
		[XmlEnum(Name = "Business")]
		Business = 306,

		[Display(Name = "Industrial")]
		[XmlEnum(Name = "Industrial")]
		Industrial = 307,

		[Display(Name = "Parking")]
		[XmlEnum(Name = "Parking")]
		Parking = 308,

		[Display(Name = "Institutional - Special Purpose")]
		[XmlEnum(Name = "Institutional - Special Purpose")]
		Institutional___Special_Purpose = 309,

		[Display(Name = "Multi-family")]
		[XmlEnum(Name = "Multi-family")]
		Multi_family = 310,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 311,

		[Display(Name = "Hospitality")]
		[XmlEnum(Name = "Hospitality")]
		Hospitality = 312
    }
}