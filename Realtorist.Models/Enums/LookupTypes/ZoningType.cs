using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ZoningType
    {
		[Display(Name = "Agricultural")]
		[XmlEnum(Name = "Agricultural")]
		Agricultural = 2,

		[Display(Name = "Single detached residential")]
		[XmlEnum(Name = "Single detached residential")]
		Single_detached_residential = 36,

		[Display(Name = "Planned lot residential")]
		[XmlEnum(Name = "Planned lot residential")]
		Planned_lot_residential = 44,

		[Display(Name = "High Rise")]
		[XmlEnum(Name = "High Rise")]
		High_Rise = 93,

		[Display(Name = "Residential apartment")]
		[XmlEnum(Name = "Residential apartment")]
		Residential_apartment = 62,

		[Display(Name = "Residential high density")]
		[XmlEnum(Name = "Residential high density")]
		Residential_high_density = 58,

		[Display(Name = "High rise apartment")]
		[XmlEnum(Name = "High rise apartment")]
		High_rise_apartment = 35,

		[Display(Name = "Multiple unit dwelling")]
		[XmlEnum(Name = "Multiple unit dwelling")]
		Multiple_unit_dwelling = 76,

		[Display(Name = "Four unit dwelling")]
		[XmlEnum(Name = "Four unit dwelling")]
		Four_unit_dwelling = 75,

		[Display(Name = "Two unit dwelling")]
		[XmlEnum(Name = "Two unit dwelling")]
		Two_unit_dwelling = 74,

		[Display(Name = "Residential up/down duplex")]
		[XmlEnum(Name = "Residential up/down duplex")]
		Residential_up_down_duplex = 69,

		[Display(Name = "Residential medium density")]
		[XmlEnum(Name = "Residential medium density")]
		Residential_medium_density = 57,

		[Display(Name = "Medium density multiple family")]
		[XmlEnum(Name = "Medium density multiple family")]
		Medium_density_multiple_family = 41,

		[Display(Name = "Semi-detached redevelopment")]
		[XmlEnum(Name = "Semi-detached redevelopment")]
		Semi_detached_redevelopment = 39,

		[Display(Name = "Row housing")]
		[XmlEnum(Name = "Row housing")]
		Row_housing = 40,

		[Display(Name = "Duplex")]
		[XmlEnum(Name = "Duplex")]
		Duplex = 4,

		[Display(Name = "Medium rise apartment")]
		[XmlEnum(Name = "Medium rise apartment")]
		Medium_rise_apartment = 34,

		[Display(Name = "Low density infill")]
		[XmlEnum(Name = "Low density infill")]
		Low_density_infill = 37,

		[Display(Name = "Residential low density")]
		[XmlEnum(Name = "Residential low density")]
		Residential_low_density = 56,

		[Display(Name = "Low rise apartment")]
		[XmlEnum(Name = "Low rise apartment")]
		Low_rise_apartment = 33,

		[Display(Name = "Low density redevelopment")]
		[XmlEnum(Name = "Low density redevelopment")]
		Low_density_redevelopment = 38,

		[Display(Name = "Townhouse Strata")]
		[XmlEnum(Name = "Townhouse Strata")]
		Townhouse_Strata = 104,

		[Display(Name = "Personal Strata")]
		[XmlEnum(Name = "Personal Strata")]
		Personal_Strata = 99,

		[Display(Name = "Condominium Strata")]
		[XmlEnum(Name = "Condominium Strata")]
		Condominium_Strata = 106,

		[Display(Name = "Single family dwelling")]
		[XmlEnum(Name = "Single family dwelling")]
		Single_family_dwelling = 10,

		[Display(Name = "Subdivision")]
		[XmlEnum(Name = "Subdivision")]
		Subdivision = 15,

		[Display(Name = "Residential small lot")]
		[XmlEnum(Name = "Residential small lot")]
		Residential_small_lot = 60,

		[Display(Name = "Restricted small lot")]
		[XmlEnum(Name = "Restricted small lot")]
		Restricted_small_lot = 61,

		[Display(Name = "Urban reserve")]
		[XmlEnum(Name = "Urban reserve")]
		Urban_reserve = 51,

		[Display(Name = "Temporary holding")]
		[XmlEnum(Name = "Temporary holding")]
		Temporary_holding = 28,

		[Display(Name = "Site specific development control")]
		[XmlEnum(Name = "Site specific development control")]
		Site_specific_development_control = 29,

		[Display(Name = "Reserved for future")]
		[XmlEnum(Name = "Reserved for future")]
		Reserved_for_future = 66,

		[Display(Name = "Public use")]
		[XmlEnum(Name = "Public use")]
		Public_use = 52,

		[Display(Name = "Parkland")]
		[XmlEnum(Name = "Parkland")]
		Parkland = 50,

		[Display(Name = "Park")]
		[XmlEnum(Name = "Park")]
		Park = 83,

		[Display(Name = "Highway corridor")]
		[XmlEnum(Name = "Highway corridor")]
		Highway_corridor = 21,

		[Display(Name = "Direct development control")]
		[XmlEnum(Name = "Direct development control")]
		Direct_development_control = 26,

		[Display(Name = "Conservation area")]
		[XmlEnum(Name = "Conservation area")]
		Conservation_area = 89,

		[Display(Name = "Comprehensively planned development")]
		[XmlEnum(Name = "Comprehensively planned development")]
		Comprehensively_planned_development = 27,

		[Display(Name = "Residential mixed")]
		[XmlEnum(Name = "Residential mixed")]
		Residential_mixed = 59,

		[Display(Name = "Day care facility")]
		[XmlEnum(Name = "Day care facility")]
		Day_care_facility = 55,

		[Display(Name = "Mature adult community")]
		[XmlEnum(Name = "Mature adult community")]
		Mature_adult_community = 64,

		[Display(Name = "Retail Strata")]
		[XmlEnum(Name = "Retail Strata")]
		Retail_Strata = 102,

		[Display(Name = "Shopping centre")]
		[XmlEnum(Name = "Shopping centre")]
		Shopping_centre = 25,

		[Display(Name = "Retail")]
		[XmlEnum(Name = "Retail")]
		Retail = 101,

		[Display(Name = "Country residential")]
		[XmlEnum(Name = "Country residential")]
		Country_residential = 78,

		[Display(Name = "Rural residential")]
		[XmlEnum(Name = "Rural residential")]
		Rural_residential = 45,

		[Display(Name = "Restricted residential")]
		[XmlEnum(Name = "Restricted residential")]
		Restricted_residential = 77,

		[Display(Name = "Restricted residential lot")]
		[XmlEnum(Name = "Restricted residential lot")]
		Restricted_residential_lot = 70,

		[Display(Name = "Large single dwelling")]
		[XmlEnum(Name = "Large single dwelling")]
		Large_single_dwelling = 73,

		[Display(Name = "Small single dwelling")]
		[XmlEnum(Name = "Small single dwelling")]
		Small_single_dwelling = 72,

		[Display(Name = "Residential 2 dwellings")]
		[XmlEnum(Name = "Residential 2 dwellings")]
		Residential_2_dwellings = 67,

		[Display(Name = "Residential special community")]
		[XmlEnum(Name = "Residential special community")]
		Residential_special_community = 68,

		[Display(Name = "Development Site")]
		[XmlEnum(Name = "Development Site")]
		Development_Site = 16,

		[Display(Name = "Townhouse")]
		[XmlEnum(Name = "Townhouse")]
		Townhouse = 103,

		[Display(Name = "Residential mixed use")]
		[XmlEnum(Name = "Residential mixed use")]
		Residential_mixed_use = 43,

		[Display(Name = "Heavy industrial")]
		[XmlEnum(Name = "Heavy industrial")]
		Heavy_industrial = 31,

		[Display(Name = "Industrial")]
		[XmlEnum(Name = "Industrial")]
		Industrial = 6,

		[Display(Name = "Heritage mixed use")]
		[XmlEnum(Name = "Heritage mixed use")]
		Heritage_mixed_use = 63,

		[Display(Name = "Convenience commercial")]
		[XmlEnum(Name = "Convenience commercial")]
		Convenience_commercial = 53,

		[Display(Name = "Neighbourhood convenience commercial")]
		[XmlEnum(Name = "Neighbourhood convenience commercial")]
		Neighbourhood_convenience_commercial = 23,

		[Display(Name = "Central Business District")]
		[XmlEnum(Name = "Central Business District")]
		Central_Business_District = 91,

		[Display(Name = "Neighborhood Business District")]
		[XmlEnum(Name = "Neighborhood Business District")]
		Neighborhood_Business_District = 108,

		[Display(Name = "Commercial/Business/Manufacturing")]
		[XmlEnum(Name = "Commercial/Business/Manufacturing")]
		Commercial_Business_Manufacturing = 46,

		[Display(Name = "Commercial mixed use")]
		[XmlEnum(Name = "Commercial mixed use")]
		Commercial_mixed_use = 22,

		[Display(Name = "Rural commercial")]
		[XmlEnum(Name = "Rural commercial")]
		Rural_commercial = 54,

		[Display(Name = "Service commercial")]
		[XmlEnum(Name = "Service commercial")]
		Service_commercial = 81,

		[Display(Name = "Arterial commercial")]
		[XmlEnum(Name = "Arterial commercial")]
		Arterial_commercial = 82,

		[Display(Name = "Highway commercial")]
		[XmlEnum(Name = "Highway commercial")]
		Highway_commercial = 48,

		[Display(Name = "Commercial Strata")]
		[XmlEnum(Name = "Commercial Strata")]
		Commercial_Strata = 90,

		[Display(Name = "General business")]
		[XmlEnum(Name = "General business")]
		General_business = 20,

		[Display(Name = "Downtown commercial")]
		[XmlEnum(Name = "Downtown commercial")]
		Downtown_commercial = 79,

		[Display(Name = "Commercial")]
		[XmlEnum(Name = "Commercial")]
		Commercial = 3,

		[Display(Name = "Professional")]
		[XmlEnum(Name = "Professional")]
		Professional = 100,

		[Display(Name = "Low intensity business")]
		[XmlEnum(Name = "Low intensity business")]
		Low_intensity_business = 19,

		[Display(Name = "Business")]
		[XmlEnum(Name = "Business")]
		Business = 49,

		[Display(Name = "Mushroom plant")]
		[XmlEnum(Name = "Mushroom plant")]
		Mushroom_plant = 65,

		[Display(Name = "Restricted agricultural")]
		[XmlEnum(Name = "Restricted agricultural")]
		Restricted_agricultural = 88,

		[Display(Name = "In ALR")]
		[XmlEnum(Name = "In ALR")]
		In_ALR = 5,

		[Display(Name = "Medium Industrial")]
		[XmlEnum(Name = "Medium Industrial")]
		Medium_Industrial = 32,

		[Display(Name = "Light industrial")]
		[XmlEnum(Name = "Light industrial")]
		Light_industrial = 47,

		[Display(Name = "Warehouse")]
		[XmlEnum(Name = "Warehouse")]
		Warehouse = 14,

		[Display(Name = "Industrial business")]
		[XmlEnum(Name = "Industrial business")]
		Industrial_business = 30,

		[Display(Name = "Residential/Commercial")]
		[XmlEnum(Name = "Residential/Commercial")]
		Residential_Commercial = 12,

		[Display(Name = "Residential")]
		[XmlEnum(Name = "Residential")]
		Residential = 11,

		[Display(Name = "Vacationing area")]
		[XmlEnum(Name = "Vacationing area")]
		Vacationing_area = 109,

		[Display(Name = "Rural recreational")]
		[XmlEnum(Name = "Rural recreational")]
		Rural_recreational = 71,

		[Display(Name = "Recreational")]
		[XmlEnum(Name = "Recreational")]
		Recreational = 17,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 1,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 9,

		[Display(Name = "Conforming Use")]
		[XmlEnum(Name = "Conforming Use")]
		Conforming_Use = 107,

		[Display(Name = "Non-conforming")]
		[XmlEnum(Name = "Non-conforming")]
		Non_conforming = 13,

		[Display(Name = "Variance in Place")]
		[XmlEnum(Name = "Variance in Place")]
		Variance_in_Place = 105,

		[Display(Name = "Multi-Use")]
		[XmlEnum(Name = "Multi-Use")]
		Multi_Use = 96,

		[Display(Name = "Multi-Family")]
		[XmlEnum(Name = "Multi-Family")]
		Multi_Family = 7,

		[Display(Name = "Mixed")]
		[XmlEnum(Name = "Mixed")]
		Mixed = 95,

		[Display(Name = "Contract zone")]
		[XmlEnum(Name = "Contract zone")]
		Contract_zone = 84,

		[Display(Name = "Transitional")]
		[XmlEnum(Name = "Transitional")]
		Transitional = 80,

		[Display(Name = "Commercial office")]
		[XmlEnum(Name = "Commercial office")]
		Commercial_office = 24,

		[Display(Name = "Office Strata")]
		[XmlEnum(Name = "Office Strata")]
		Office_Strata = 98,

		[Display(Name = "Office")]
		[XmlEnum(Name = "Office")]
		Office = 97,

		[Display(Name = "Mobile home")]
		[XmlEnum(Name = "Mobile home")]
		Mobile_home = 42,

		[Display(Name = "Institutional")]
		[XmlEnum(Name = "Institutional")]
		Institutional = 18,

		[Display(Name = "Industrial medium density")]
		[XmlEnum(Name = "Industrial medium density")]
		Industrial_medium_density = 86,

		[Display(Name = "Light industrial high density")]
		[XmlEnum(Name = "Light industrial high density")]
		Light_industrial_high_density = 85,

		[Display(Name = "Industrial Strata")]
		[XmlEnum(Name = "Industrial Strata")]
		Industrial_Strata = 94,

		[Display(Name = "Airport industrial")]
		[XmlEnum(Name = "Airport industrial")]
		Airport_industrial = 87,

		[Display(Name = "Cluster")]
		[XmlEnum(Name = "Cluster")]
		Cluster = 92,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 110
    }
}