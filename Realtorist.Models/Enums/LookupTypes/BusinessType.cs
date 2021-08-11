using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum BusinessType
    {
		[Display(Name = "Accommodation")]
		[XmlEnum(Name = "Accommodation")]
		Accommodation = 400,

		[Display(Name = "Mining and Oil and Gas")]
		[XmlEnum(Name = "Mining and Oil and Gas")]
		Mining_and_Oil_and_Gas = 430,

		[Display(Name = "Hospitality")]
		[XmlEnum(Name = "Hospitality")]
		Hospitality = 429,

		[Display(Name = "Health Care and Social Assistance")]
		[XmlEnum(Name = "Health Care and Social Assistance")]
		Health_Care_and_Social_Assistance = 428,

		[Display(Name = "Real Estate")]
		[XmlEnum(Name = "Real Estate")]
		Real_Estate = 427,

		[Display(Name = "Waste Management")]
		[XmlEnum(Name = "Waste Management")]
		Waste_Management = 426,

		[Display(Name = "Utilities")]
		[XmlEnum(Name = "Utilities")]
		Utilities = 425,

		[Display(Name = "Transportation and Warehousing")]
		[XmlEnum(Name = "Transportation and Warehousing")]
		Transportation_and_Warehousing = 424,

		[Display(Name = "Administrative and Support")]
		[XmlEnum(Name = "Administrative and Support")]
		Administrative_and_Support = 423,

		[Display(Name = "Finance and Insurance")]
		[XmlEnum(Name = "Finance and Insurance")]
		Finance_and_Insurance = 422,

		[Display(Name = "Education Services")]
		[XmlEnum(Name = "Education Services")]
		Education_Services = 421,

		[Display(Name = "Consulting")]
		[XmlEnum(Name = "Consulting")]
		Consulting = 420,

		[Display(Name = "Remediation Services")]
		[XmlEnum(Name = "Remediation Services")]
		Remediation_Services = 419,

		[Display(Name = "Arts and Entertainment")]
		[XmlEnum(Name = "Arts and Entertainment")]
		Arts_and_Entertainment = 418,

		[Display(Name = "Professional, Scientific and Hi Tech Services")]
		[XmlEnum(Name = "Professional, Scientific and Hi Tech Services")]
		Professional_Scientific_and_Hi_Tech_Services = 417,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 431,

		[Display(Name = "Service")]
		[XmlEnum(Name = "Service")]
		Service = 416,

		[Display(Name = "Residential")]
		[XmlEnum(Name = "Residential")]
		Residential = 414,

		[Display(Name = "Retail and Wholesale")]
		[XmlEnum(Name = "Retail and Wholesale")]
		Retail_and_Wholesale = 413,

		[Display(Name = "Resort")]
		[XmlEnum(Name = "Resort")]
		Resort = 412,

		[Display(Name = "Restaurant")]
		[XmlEnum(Name = "Restaurant")]
		Restaurant = 411,

		[Display(Name = "Recreation")]
		[XmlEnum(Name = "Recreation")]
		Recreation = 410,

		[Display(Name = "Personal Services")]
		[XmlEnum(Name = "Personal Services")]
		Personal_Services = 409,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 408,

		[Display(Name = "Manufacturing")]
		[XmlEnum(Name = "Manufacturing")]
		Manufacturing = 407,

		[Display(Name = "Institutional")]
		[XmlEnum(Name = "Institutional")]
		Institutional = 406,

		[Display(Name = "Industrial")]
		[XmlEnum(Name = "Industrial")]
		Industrial = 405,

		[Display(Name = "Food Services and Beverage")]
		[XmlEnum(Name = "Food Services and Beverage")]
		Food_Services_and_Beverage = 404,

		[Display(Name = "Construction")]
		[XmlEnum(Name = "Construction")]
		Construction = 403,

		[Display(Name = "Automobile")]
		[XmlEnum(Name = "Automobile")]
		Automobile = 402,

		[Display(Name = "Agriculture, Forestry, Fishing and Hunting")]
		[XmlEnum(Name = "Agriculture, Forestry, Fishing and Hunting")]
		Agriculture_Forestry_Fishing_and_Hunting = 401,

		[Display(Name = "Special Purpose")]
		[XmlEnum(Name = "Special Purpose")]
		Special_Purpose = 415,

		[Display(Name = "Information and Cultural Industries")]
		[XmlEnum(Name = "Information and Cultural Industries")]
		Information_and_Cultural_Industries = 432
    }
}