using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Amenities
    {
		[Display(Name = "Shopping Area")]
		[XmlEnum(Name = "Shopping Area")]
		Shopping_Area = 1,

		[Display(Name = "RV Storage")]
		[XmlEnum(Name = "RV Storage")]
		RV_Storage = 35,

		[Display(Name = "Secured Parking")]
		[XmlEnum(Name = "Secured Parking")]
		Secured_Parking = 36,

		[Display(Name = "Skating")]
		[XmlEnum(Name = "Skating")]
		Skating = 37,

		[Display(Name = "Storage - In Suite")]
		[XmlEnum(Name = "Storage - In Suite")]
		Storage___In_Suite = 38,

		[Display(Name = "Tobogganing")]
		[XmlEnum(Name = "Tobogganing")]
		Tobogganing = 39,

		[Display(Name = "Swimming")]
		[XmlEnum(Name = "Swimming")]
		Swimming = 40,

		[Display(Name = "Ceiling - 9ft")]
		[XmlEnum(Name = "Ceiling - 9ft")]
		Ceiling___9ft = 41,

		[Display(Name = "Ceiling - 10ft")]
		[XmlEnum(Name = "Ceiling - 10ft")]
		Ceiling___10ft = 42,

		[Display(Name = "Detectors - CO2")]
		[XmlEnum(Name = "Detectors - CO2")]
		Detectors___CO2 = 43,

		[Display(Name = "Security Window/Bars")]
		[XmlEnum(Name = "Security Window/Bars")]
		Security_Window_Bars = 44,

		[Display(Name = "Sunroom/Solarium")]
		[XmlEnum(Name = "Sunroom/Solarium")]
		Sunroom_Solarium = 45,

		[Display(Name = "Vaulted Ceiling")]
		[XmlEnum(Name = "Vaulted Ceiling")]
		Vaulted_Ceiling = 46,

		[Display(Name = "Vinyl Windows")]
		[XmlEnum(Name = "Vinyl Windows")]
		Vinyl_Windows = 47,

		[Display(Name = "Music Room")]
		[XmlEnum(Name = "Music Room")]
		Music_Room = 48,

		[Display(Name = "Party Room")]
		[XmlEnum(Name = "Party Room")]
		Party_Room = 49,

		[Display(Name = "Sauna")]
		[XmlEnum(Name = "Sauna")]
		Sauna = 50,

		[Display(Name = "Whirlpool")]
		[XmlEnum(Name = "Whirlpool")]
		Whirlpool = 51,

		[Display(Name = "Air Conditioning")]
		[XmlEnum(Name = "Air Conditioning")]
		Air_Conditioning = 52,

		[Display(Name = "Furnished")]
		[XmlEnum(Name = "Furnished")]
		Furnished = 53,

		[Display(Name = "Unfurnished")]
		[XmlEnum(Name = "Unfurnished")]
		Unfurnished = 54,

		[Display(Name = "Clubhouse")]
		[XmlEnum(Name = "Clubhouse")]
		Clubhouse = 55,

		[Display(Name = "Dining Facility")]
		[XmlEnum(Name = "Dining Facility")]
		Dining_Facility = 56,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 57,

		[Display(Name = "Cable TV")]
		[XmlEnum(Name = "Cable TV")]
		Cable_TV = 58,

		[Display(Name = "Fireplace(s)")]
		[XmlEnum(Name = "Fireplace(s)")]
		Fireplaces = 59,

		[Display(Name = "Indoor Parking")]
		[XmlEnum(Name = "Indoor Parking")]
		Indoor_Parking = 60,

		[Display(Name = "Multi-Use Rooms")]
		[XmlEnum(Name = "Multi-Use Rooms")]
		Multi_Use_Rooms = 61,

		[Display(Name = "Racquet Courts")]
		[XmlEnum(Name = "Racquet Courts")]
		Racquet_Courts = 62,

		[Display(Name = "Security Room")]
		[XmlEnum(Name = "Security Room")]
		Security_Room = 63,

		[Display(Name = "Picnic Area")]
		[XmlEnum(Name = "Picnic Area")]
		Picnic_Area = 34,

		[Display(Name = "Security/Concierge")]
		[XmlEnum(Name = "Security/Concierge")]
		Security_Concierge = 64,

		[Display(Name = "Laundry - In Suite")]
		[XmlEnum(Name = "Laundry - In Suite")]
		Laundry___In_Suite = 33,

		[Display(Name = "Guest Suite")]
		[XmlEnum(Name = "Guest Suite")]
		Guest_Suite = 31,

		[Display(Name = "Storage - Locker")]
		[XmlEnum(Name = "Storage - Locker")]
		Storage___Locker = 2,

		[Display(Name = "Laundry Facility")]
		[XmlEnum(Name = "Laundry Facility")]
		Laundry_Facility = 3,

		[Display(Name = "Balconies")]
		[XmlEnum(Name = "Balconies")]
		Balconies = 4,

		[Display(Name = "Mezzanine")]
		[XmlEnum(Name = "Mezzanine")]
		Mezzanine = 5,

		[Display(Name = "Storefront")]
		[XmlEnum(Name = "Storefront")]
		Storefront = 6,

		[Display(Name = "Daycare")]
		[XmlEnum(Name = "Daycare")]
		Daycare = 7,

		[Display(Name = "Car Wash")]
		[XmlEnum(Name = "Car Wash")]
		Car_Wash = 8,

		[Display(Name = "Canopy")]
		[XmlEnum(Name = "Canopy")]
		Canopy = 9,

		[Display(Name = "Living Accommodation")]
		[XmlEnum(Name = "Living Accommodation")]
		Living_Accommodation = 10,

		[Display(Name = "Catering/Food Sales")]
		[XmlEnum(Name = "Catering/Food Sales")]
		Catering_Food_Sales = 11,

		[Display(Name = "Commercial Condominium")]
		[XmlEnum(Name = "Commercial Condominium")]
		Commercial_Condominium = 12,

		[Display(Name = "Common Area Indoors")]
		[XmlEnum(Name = "Common Area Indoors")]
		Common_Area_Indoors = 13,

		[Display(Name = "Compound")]
		[XmlEnum(Name = "Compound")]
		Compound = 14,

		[Display(Name = "Entertainment/Video")]
		[XmlEnum(Name = "Entertainment/Video")]
		Entertainment_Video = 15,

		[Display(Name = "Exercise Centre")]
		[XmlEnum(Name = "Exercise Centre")]
		Exercise_Centre = 16,

		[Display(Name = "FaГ§ade")]
		[XmlEnum(Name = "FaГ§ade")]
		Faade = 17,

		[Display(Name = "Florist")]
		[XmlEnum(Name = "Florist")]
		Florist = 18,

		[Display(Name = "Food Services")]
		[XmlEnum(Name = "Food Services")]
		Food_Services = 19,

		[Display(Name = "Licensed Dining")]
		[XmlEnum(Name = "Licensed Dining")]
		Licensed_Dining = 20,

		[Display(Name = "Recreation Centre")]
		[XmlEnum(Name = "Recreation Centre")]
		Recreation_Centre = 21,

		[Display(Name = "Residence")]
		[XmlEnum(Name = "Residence")]
		Residence = 22,

		[Display(Name = "Restaurant")]
		[XmlEnum(Name = "Restaurant")]
		Restaurant = 23,

		[Display(Name = "Shared Laundry")]
		[XmlEnum(Name = "Shared Laundry")]
		Shared_Laundry = 24,

		[Display(Name = "Street Lighting")]
		[XmlEnum(Name = "Street Lighting")]
		Street_Lighting = 25,

		[Display(Name = "Separate Electricity Meters")]
		[XmlEnum(Name = "Separate Electricity Meters")]
		Separate_Electricity_Meters = 26,

		[Display(Name = "Separate Heating Controls")]
		[XmlEnum(Name = "Separate Heating Controls")]
		Separate_Heating_Controls = 27,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 28,

		[Display(Name = "Gazebo")]
		[XmlEnum(Name = "Gazebo")]
		Gazebo = 29,

		[Display(Name = "Assisted Living")]
		[XmlEnum(Name = "Assisted Living")]
		Assisted_Living = 30,

		[Display(Name = "Laundry - Coin Op")]
		[XmlEnum(Name = "Laundry - Coin Op")]
		Laundry___Coin_Op = 32,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 65
    }
}