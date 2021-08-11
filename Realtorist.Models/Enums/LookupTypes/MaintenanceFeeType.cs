using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum MaintenanceFeeType
    {
		[Display(Name = "Common Area Maintenance")]
		[XmlEnum(Name = "Common Area Maintenance")]
		Common_Area_Maintenance = 1,

		[Display(Name = "Reserve Fund Contributions")]
		[XmlEnum(Name = "Reserve Fund Contributions")]
		Reserve_Fund_Contributions = 24,

		[Display(Name = "Recreation Facilities")]
		[XmlEnum(Name = "Recreation Facilities")]
		Recreation_Facilities = 23,

		[Display(Name = "Parking")]
		[XmlEnum(Name = "Parking")]
		Parking = 22,

		[Display(Name = "Condominium Amenities")]
		[XmlEnum(Name = "Condominium Amenities")]
		Condominium_Amenities = 21,

		[Display(Name = "Other, See Remarks")]
		[XmlEnum(Name = "Other, See Remarks")]
		Other_See_Remarks = 20,

		[Display(Name = "Insurance")]
		[XmlEnum(Name = "Insurance")]
		Insurance = 19,

		[Display(Name = "Water")]
		[XmlEnum(Name = "Water")]
		Water = 18,

		[Display(Name = "Electricity")]
		[XmlEnum(Name = "Electricity")]
		Electricity = 17,

		[Display(Name = "Heat")]
		[XmlEnum(Name = "Heat")]
		Heat = 16,

		[Display(Name = "Ground Maintenance")]
		[XmlEnum(Name = "Ground Maintenance")]
		Ground_Maintenance = 15,

		[Display(Name = "Caretaker")]
		[XmlEnum(Name = "Caretaker")]
		Caretaker = 14,

		[Display(Name = "Cable TV")]
		[XmlEnum(Name = "Cable TV")]
		Cable_TV = 13,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 12,

		[Display(Name = "Waste Removal")]
		[XmlEnum(Name = "Waste Removal")]
		Waste_Removal = 11,

		[Display(Name = "Security")]
		[XmlEnum(Name = "Security")]
		Security = 10,

		[Display(Name = "Property Management")]
		[XmlEnum(Name = "Property Management")]
		Property_Management = 9,

		[Display(Name = "Property Inspection")]
		[XmlEnum(Name = "Property Inspection")]
		Property_Inspection = 8,

		[Display(Name = "Plumbing Repairs")]
		[XmlEnum(Name = "Plumbing Repairs")]
		Plumbing_Repairs = 7,

		[Display(Name = "Landscaping")]
		[XmlEnum(Name = "Landscaping")]
		Landscaping = 6,

		[Display(Name = "Lawn Care")]
		[XmlEnum(Name = "Lawn Care")]
		Lawn_Care = 5,

		[Display(Name = "Interior Maintenance")]
		[XmlEnum(Name = "Interior Maintenance")]
		Interior_Maintenance = 4,

		[Display(Name = "Exterior Maintenance")]
		[XmlEnum(Name = "Exterior Maintenance")]
		Exterior_Maintenance = 3,

		[Display(Name = "Electrical Repairs")]
		[XmlEnum(Name = "Electrical Repairs")]
		Electrical_Repairs = 2,

		[Display(Name = "Residential Manager")]
		[XmlEnum(Name = "Residential Manager")]
		Residential_Manager = 25,

		[Display(Name = "Sewer")]
		[XmlEnum(Name = "Sewer")]
		Sewer = 26
    }
}