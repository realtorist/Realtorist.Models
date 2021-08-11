using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ArchitecturalStyle
    {
		[Display(Name = "Hillside Bungalow")]
		[XmlEnum(Name = "Hillside Bungalow")]
		Hillside_Bungalow = 53,

		[Display(Name = "Basement entry")]
		[XmlEnum(Name = "Basement entry")]
		Basement_entry = 44,

		[Display(Name = "Ground level entry")]
		[XmlEnum(Name = "Ground level entry")]
		Ground_level_entry = 45,

		[Display(Name = "Bi-level")]
		[XmlEnum(Name = "Bi-level")]
		Bi_level = 49,

		[Display(Name = "Split level entry")]
		[XmlEnum(Name = "Split level entry")]
		Split_level_entry = 67,

		[Display(Name = "2 Level")]
		[XmlEnum(Name = "2 Level")]
		_2_Level = 75,

		[Display(Name = "3 Level")]
		[XmlEnum(Name = "3 Level")]
		_3_Level = 76,

		[Display(Name = "4 Level")]
		[XmlEnum(Name = "4 Level")]
		_4_Level = 77,

		[Display(Name = "5 Level")]
		[XmlEnum(Name = "5 Level")]
		_5_Level = 78,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 16,

		[Display(Name = "Multi-level")]
		[XmlEnum(Name = "Multi-level")]
		Multi_level = 31,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 79,

		[Display(Name = "Tower")]
		[XmlEnum(Name = "Tower")]
		Tower = 107,

		[Display(Name = "High rise")]
		[XmlEnum(Name = "High rise")]
		High_rise = 108,

		[Display(Name = "Low rise")]
		[XmlEnum(Name = "Low rise")]
		Low_rise = 109,

		[Display(Name = "Multi-Unit")]
		[XmlEnum(Name = "Multi-Unit")]
		Multi_Unit = 110,

		[Display(Name = "Cab-Over")]
		[XmlEnum(Name = "Cab-Over")]
		Cab_Over = 111,

		[Display(Name = "Mobile Home")]
		[XmlEnum(Name = "Mobile Home")]
		Mobile_Home = 112,

		[Display(Name = "Loft")]
		[XmlEnum(Name = "Loft")]
		Loft = 113,

		[Display(Name = "Cross Dock")]
		[XmlEnum(Name = "Cross Dock")]
		Cross_Dock = 114,

		[Display(Name = "Lower Level")]
		[XmlEnum(Name = "Lower Level")]
		Lower_Level = 115,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 103,

		[Display(Name = "Cathedral entry")]
		[XmlEnum(Name = "Cathedral entry")]
		Cathedral_entry = 42,

		[Display(Name = "Westcoast")]
		[XmlEnum(Name = "Westcoast")]
		Westcoast = 15,

		[Display(Name = "Tudor")]
		[XmlEnum(Name = "Tudor")]
		Tudor = 14,

		[Display(Name = "Split entry bungalow")]
		[XmlEnum(Name = "Split entry bungalow")]
		Split_entry_bungalow = 29,

		[Display(Name = "A-Frame")]
		[XmlEnum(Name = "A-Frame")]
		A_Frame = 61,

		[Display(Name = "Bungalow")]
		[XmlEnum(Name = "Bungalow")]
		Bungalow = 1,

		[Display(Name = "Contemporary")]
		[XmlEnum(Name = "Contemporary")]
		Contemporary = 41,

		[Display(Name = "Cape Cod")]
		[XmlEnum(Name = "Cape Cod")]
		Cape_Cod = 56,

		[Display(Name = "Carriage")]
		[XmlEnum(Name = "Carriage")]
		Carriage = 96,

		[Display(Name = "Chalet")]
		[XmlEnum(Name = "Chalet")]
		Chalet = 68,

		[Display(Name = "Character")]
		[XmlEnum(Name = "Character")]
		Character = 2,

		[Display(Name = "Church")]
		[XmlEnum(Name = "Church")]
		Church = 97,

		[Display(Name = "Cottage")]
		[XmlEnum(Name = "Cottage")]
		Cottage = 3,

		[Display(Name = "Cabin")]
		[XmlEnum(Name = "Cabin")]
		Cabin = 105,

		[Display(Name = "Camp")]
		[XmlEnum(Name = "Camp")]
		Camp = 69,

		[Display(Name = "Custom")]
		[XmlEnum(Name = "Custom")]
		Custom = 4,

		[Display(Name = "Log house/cabin")]
		[XmlEnum(Name = "Log house/cabin")]
		Log_house_cabin = 9,

		[Display(Name = "Luxury Villa")]
		[XmlEnum(Name = "Luxury Villa")]
		Luxury_Villa = 95,

		[Display(Name = "Mini")]
		[XmlEnum(Name = "Mini")]
		Mini = 73,

		[Display(Name = "Neighbourhood")]
		[XmlEnum(Name = "Neighbourhood")]
		Neighbourhood = 100,

		[Display(Name = "Penthouse")]
		[XmlEnum(Name = "Penthouse")]
		Penthouse = 52,

		[Display(Name = "Raised bungalow")]
		[XmlEnum(Name = "Raised bungalow")]
		Raised_bungalow = 28,

		[Display(Name = "Raised ranch")]
		[XmlEnum(Name = "Raised ranch")]
		Raised_ranch = 19,

		[Display(Name = "Ranch")]
		[XmlEnum(Name = "Ranch")]
		Ranch = 12,

		[Display(Name = "Off 2nd Floor")]
		[XmlEnum(Name = "Off 2nd Floor")]
		Off_2nd_Floor = 116,

		[Display(Name = "Raised Ranch w/ Bonus Room")]
		[XmlEnum(Name = "Raised Ranch w/ Bonus Room")]
		Raised_Ranch_w__Bonus_Room = 117
    }
}