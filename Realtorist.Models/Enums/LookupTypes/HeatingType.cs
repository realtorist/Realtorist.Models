using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum HeatingType
    {
		[Display(Name = "Heat Pump")]
		[XmlEnum(Name = "Heat Pump")]
		Heat_Pump = 1,

		[Display(Name = "Boiler")]
		[XmlEnum(Name = "Boiler")]
		Boiler = 22,

		[Display(Name = "Space Heater")]
		[XmlEnum(Name = "Space Heater")]
		Space_Heater = 23,

		[Display(Name = "Heat Recovery Ventilation (HRV)")]
		[XmlEnum(Name = "Heat Recovery Ventilation (HRV)")]
		Heat_Recovery_Ventilation_HRV = 24,

		[Display(Name = "High-Efficiency Furnace")]
		[XmlEnum(Name = "High-Efficiency Furnace")]
		High_Efficiency_Furnace = 25,

		[Display(Name = "See remarks")]
		[XmlEnum(Name = "See remarks")]
		See_remarks = 26,

		[Display(Name = "Central heating")]
		[XmlEnum(Name = "Central heating")]
		Central_heating = 27,

		[Display(Name = "Floor heat")]
		[XmlEnum(Name = "Floor heat")]
		Floor_heat = 28,

		[Display(Name = "Coil Fan")]
		[XmlEnum(Name = "Coil Fan")]
		Coil_Fan = 29,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 30,

		[Display(Name = "Radiator")]
		[XmlEnum(Name = "Radiator")]
		Radiator = 31,

		[Display(Name = "Electric Air Cleaner")]
		[XmlEnum(Name = "Electric Air Cleaner")]
		Electric_Air_Cleaner = 32,

		[Display(Name = "Hot Water")]
		[XmlEnum(Name = "Hot Water")]
		Hot_Water = 33,

		[Display(Name = "Wood Stove")]
		[XmlEnum(Name = "Wood Stove")]
		Wood_Stove = 34,

		[Display(Name = "Wall Mounted Heat Pump")]
		[XmlEnum(Name = "Wall Mounted Heat Pump")]
		Wall_Mounted_Heat_Pump = 35,

		[Display(Name = "Central Heat Pump")]
		[XmlEnum(Name = "Central Heat Pump")]
		Central_Heat_Pump = 36,

		[Display(Name = "Outside Furnace")]
		[XmlEnum(Name = "Outside Furnace")]
		Outside_Furnace = 21,

		[Display(Name = "In Floor Heating")]
		[XmlEnum(Name = "In Floor Heating")]
		In_Floor_Heating = 20,

		[Display(Name = "No heat")]
		[XmlEnum(Name = "No heat")]
		No_heat = 19,

		[Display(Name = "Not known")]
		[XmlEnum(Name = "Not known")]
		Not_known = 18,

		[Display(Name = "Air circulation heat")]
		[XmlEnum(Name = "Air circulation heat")]
		Air_circulation_heat = 2,

		[Display(Name = "Hot water radiator heat")]
		[XmlEnum(Name = "Hot water radiator heat")]
		Hot_water_radiator_heat = 3,

		[Display(Name = "Baseboard heaters")]
		[XmlEnum(Name = "Baseboard heaters")]
		Baseboard_heaters = 4,

		[Display(Name = "Electric baseboard units")]
		[XmlEnum(Name = "Electric baseboard units")]
		Electric_baseboard_units = 5,

		[Display(Name = "Space heating baseboards")]
		[XmlEnum(Name = "Space heating baseboards")]
		Space_heating_baseboards = 6,

		[Display(Name = "Radiant heat")]
		[XmlEnum(Name = "Radiant heat")]
		Radiant_heat = 7,

		[Display(Name = "Steam radiator")]
		[XmlEnum(Name = "Steam radiator")]
		Steam_radiator = 8,

		[Display(Name = "Ductless")]
		[XmlEnum(Name = "Ductless")]
		Ductless = 37,

		[Display(Name = "Stove")]
		[XmlEnum(Name = "Stove")]
		Stove = 9,

		[Display(Name = "Forced air")]
		[XmlEnum(Name = "Forced air")]
		Forced_air = 11,

		[Display(Name = "Radiant/Infra-red Heat")]
		[XmlEnum(Name = "Radiant/Infra-red Heat")]
		Radiant_Infra_red_Heat = 12,

		[Display(Name = "Underfloor ducts")]
		[XmlEnum(Name = "Underfloor ducts")]
		Underfloor_ducts = 13,

		[Display(Name = "Wall Heaters")]
		[XmlEnum(Name = "Wall Heaters")]
		Wall_Heaters = 14,

		[Display(Name = "Gravity Heat System")]
		[XmlEnum(Name = "Gravity Heat System")]
		Gravity_Heat_System = 15,

		[Display(Name = "Overhead Heaters")]
		[XmlEnum(Name = "Overhead Heaters")]
		Overhead_Heaters = 16,

		[Display(Name = "Ground Source Heat")]
		[XmlEnum(Name = "Ground Source Heat")]
		Ground_Source_Heat = 17,

		[Display(Name = "Slow-burning stove")]
		[XmlEnum(Name = "Slow-burning stove")]
		Slow_burning_stove = 10,

		[Display(Name = "Furnace")]
		[XmlEnum(Name = "Furnace")]
		Furnace = 38
    }
}