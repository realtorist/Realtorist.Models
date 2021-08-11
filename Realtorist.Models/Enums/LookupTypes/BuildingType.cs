using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum BuildingType
    {
		[Display(Name = "House")]
		[XmlEnum(Name = "House")]
		House = 1,

		[Display(Name = "Commercial Apartment")]
		[XmlEnum(Name = "Commercial Apartment")]
		Commercial_Apartment = 28,

		[Display(Name = "Manufactured Home/Mobile")]
		[XmlEnum(Name = "Manufactured Home/Mobile")]
		Manufactured_Home_Mobile = 27,

		[Display(Name = "Modular")]
		[XmlEnum(Name = "Modular")]
		Modular = 26,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 22,

		[Display(Name = "No Building")]
		[XmlEnum(Name = "No Building")]
		No_Building = 15,

		[Display(Name = "Special Purpose")]
		[XmlEnum(Name = "Special Purpose")]
		Special_Purpose = 12,

		[Display(Name = "Commercial Mix")]
		[XmlEnum(Name = "Commercial Mix")]
		Commercial_Mix = 24,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 14,

		[Display(Name = "Multi-Tenant Industrial")]
		[XmlEnum(Name = "Multi-Tenant Industrial")]
		Multi_Tenant_Industrial = 23,

		[Display(Name = "Flex Facility")]
		[XmlEnum(Name = "Flex Facility")]
		Flex_Facility = 21,

		[Display(Name = "Manufacturing")]
		[XmlEnum(Name = "Manufacturing")]
		Manufacturing = 10,

		[Display(Name = "Warehouse")]
		[XmlEnum(Name = "Warehouse")]
		Warehouse = 9,

		[Display(Name = "Manufactured Home")]
		[XmlEnum(Name = "Manufactured Home")]
		Manufactured_Home = 29,

		[Display(Name = "Retail")]
		[XmlEnum(Name = "Retail")]
		Retail = 8,

		[Display(Name = "Multi-Family")]
		[XmlEnum(Name = "Multi-Family")]
		Multi_Family = 4,

		[Display(Name = "Parking")]
		[XmlEnum(Name = "Parking")]
		Parking = 13,

		[Display(Name = "Mobile Home")]
		[XmlEnum(Name = "Mobile Home")]
		Mobile_Home = 6,

		[Display(Name = "Residential Commercial Mix")]
		[XmlEnum(Name = "Residential Commercial Mix")]
		Residential_Commercial_Mix = 5,

		[Display(Name = "Two Apartment House")]
		[XmlEnum(Name = "Two Apartment House")]
		Two_Apartment_House = 25,

		[Display(Name = "Garden Home")]
		[XmlEnum(Name = "Garden Home")]
		Garden_Home = 20,

		[Display(Name = "Fourplex")]
		[XmlEnum(Name = "Fourplex")]
		Fourplex = 19,

		[Display(Name = "Triplex")]
		[XmlEnum(Name = "Triplex")]
		Triplex = 3,

		[Display(Name = "Duplex")]
		[XmlEnum(Name = "Duplex")]
		Duplex = 2,

		[Display(Name = "Recreational")]
		[XmlEnum(Name = "Recreational")]
		Recreational = 18,

		[Display(Name = "Apartment")]
		[XmlEnum(Name = "Apartment")]
		Apartment = 17,

		[Display(Name = "Row / Townhouse")]
		[XmlEnum(Name = "Row / Townhouse")]
		Row___Townhouse = 16,

		[Display(Name = "Offices")]
		[XmlEnum(Name = "Offices")]
		Offices = 7,

		[Display(Name = "Park Model Mobile Home")]
		[XmlEnum(Name = "Park Model Mobile Home")]
		Park_Model_Mobile_Home = 30
    }
}