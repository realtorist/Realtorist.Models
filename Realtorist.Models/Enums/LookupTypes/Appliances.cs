using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Appliances
    {
		[Display(Name = "All")]
		[XmlEnum(Name = "All")]
		All = 1,

		[Display(Name = "Storage Shed")]
		[XmlEnum(Name = "Storage Shed")]
		Storage_Shed = 70,

		[Display(Name = "Play structure")]
		[XmlEnum(Name = "Play structure")]
		Play_structure = 69,

		[Display(Name = "See remarks")]
		[XmlEnum(Name = "See remarks")]
		See_remarks = 68,

		[Display(Name = "Mobile Machinery & Equipment Inc")]
		[XmlEnum(Name = "Mobile Machinery & Equipment Inc")]
		Mobile_Machinery__Equipment_Inc = 67,

		[Display(Name = "Hot Water Instant")]
		[XmlEnum(Name = "Hot Water Instant")]
		Hot_Water_Instant = 66,

		[Display(Name = "Household Goods Included")]
		[XmlEnum(Name = "Household Goods Included")]
		Household_Goods_Included = 65,

		[Display(Name = "Fixed Machinery & Equipment Incl")]
		[XmlEnum(Name = "Fixed Machinery & Equipment Incl")]
		Fixed_Machinery__Equipment_Incl = 64,

		[Display(Name = "Furniture")]
		[XmlEnum(Name = "Furniture")]
		Furniture = 63,

		[Display(Name = "Food Centre")]
		[XmlEnum(Name = "Food Centre")]
		Food_Centre = 62,

		[Display(Name = "Drapes/Curtains")]
		[XmlEnum(Name = "Drapes/Curtains")]
		Drapes_Curtains = 60,

		[Display(Name = "Blinds")]
		[XmlEnum(Name = "Blinds")]
		Blinds = 59,

		[Display(Name = "Fridge/Stove Combo")]
		[XmlEnum(Name = "Fridge/Stove Combo")]
		Fridge_Stove_Combo = 58,

		[Display(Name = "Washer/Dryer Combo")]
		[XmlEnum(Name = "Washer/Dryer Combo")]
		Washer_Dryer_Combo = 57,

		[Display(Name = "Hood Fan")]
		[XmlEnum(Name = "Hood Fan")]
		Hood_Fan = 56,

		[Display(Name = "Water Treatment")]
		[XmlEnum(Name = "Water Treatment")]
		Water_Treatment = 55,

		[Display(Name = "Humidifier")]
		[XmlEnum(Name = "Humidifier")]
		Humidifier = 54,

		[Display(Name = "Electronic Air Cleaner")]
		[XmlEnum(Name = "Electronic Air Cleaner")]
		Electronic_Air_Cleaner = 53,

		[Display(Name = "Window Air Conditioner")]
		[XmlEnum(Name = "Window Air Conditioner")]
		Window_Air_Conditioner = 52,

		[Display(Name = "Wet Bar")]
		[XmlEnum(Name = "Wet Bar")]
		Wet_Bar = 51,

		[Display(Name = "Space Heater")]
		[XmlEnum(Name = "Space Heater")]
		Space_Heater = 71,

		[Display(Name = "Central Vacuum - Roughed In")]
		[XmlEnum(Name = "Central Vacuum - Roughed In")]
		Central_Vacuum___Roughed_In = 50,

		[Display(Name = "Two stoves")]
		[XmlEnum(Name = "Two stoves")]
		Two_stoves = 72,

		[Display(Name = "Window Coverings")]
		[XmlEnum(Name = "Window Coverings")]
		Window_Coverings = 75,

		[Display(Name = "Water Heater - Propane")]
		[XmlEnum(Name = "Water Heater - Propane")]
		Water_Heater___Propane = 95,

		[Display(Name = "Water Heater - Oil")]
		[XmlEnum(Name = "Water Heater - Oil")]
		Water_Heater___Oil = 94,

		[Display(Name = "Water Heater - Gas")]
		[XmlEnum(Name = "Water Heater - Gas")]
		Water_Heater___Gas = 93,

		[Display(Name = "Water Heater - Electric")]
		[XmlEnum(Name = "Water Heater - Electric")]
		Water_Heater___Electric = 92,

		[Display(Name = "Window/Sleeve Air Conditioner")]
		[XmlEnum(Name = "Window/Sleeve Air Conditioner")]
		Window_Sleeve_Air_Conditioner = 91,

		[Display(Name = "Washer/Dryer Stack-Up")]
		[XmlEnum(Name = "Washer/Dryer Stack-Up")]
		Washer_Dryer_Stack_Up = 90,

		[Display(Name = "C/Vac Attachments")]
		[XmlEnum(Name = "C/Vac Attachments")]
		C_Vac_Attachments = 89,

		[Display(Name = "Washer & Dryer")]
		[XmlEnum(Name = "Washer & Dryer")]
		Washer__Dryer = 88,

		[Display(Name = "Microwave Built-in")]
		[XmlEnum(Name = "Microwave Built-in")]
		Microwave_Built_in = 87,

		[Display(Name = "Jetted Tub")]
		[XmlEnum(Name = "Jetted Tub")]
		Jetted_Tub = 86,

		[Display(Name = "Freezer - Chest")]
		[XmlEnum(Name = "Freezer - Chest")]
		Freezer___Chest = 85,

		[Display(Name = "Freezer - Stand Up")]
		[XmlEnum(Name = "Freezer - Stand Up")]
		Freezer___Stand_Up = 84,

		[Display(Name = "Bar dry")]
		[XmlEnum(Name = "Bar dry")]
		Bar_dry = 83,

		[Display(Name = "Fan")]
		[XmlEnum(Name = "Fan")]
		Fan = 82,

		[Display(Name = "Satellite dish related hardware")]
		[XmlEnum(Name = "Satellite dish related hardware")]
		Satellite_dish_related_hardware = 81,

		[Display(Name = "Satellite dish receiver")]
		[XmlEnum(Name = "Satellite dish receiver")]
		Satellite_dish_receiver = 80,

		[Display(Name = "Garage door opener remote(s)")]
		[XmlEnum(Name = "Garage door opener remote(s)")]
		Garage_door_opener_remotes = 79,

		[Display(Name = "Garage door opener")]
		[XmlEnum(Name = "Garage door opener")]
		Garage_door_opener = 78,

		[Display(Name = "Two Washers")]
		[XmlEnum(Name = "Two Washers")]
		Two_Washers = 76,

		[Display(Name = "Water Distiller")]
		[XmlEnum(Name = "Water Distiller")]
		Water_Distiller = 74,

		[Display(Name = "Water Heater - Tankless")]
		[XmlEnum(Name = "Water Heater - Tankless")]
		Water_Heater___Tankless = 96,

		[Display(Name = "Alarm System - Roughed In")]
		[XmlEnum(Name = "Alarm System - Roughed In")]
		Alarm_System___Roughed_In = 49,

		[Display(Name = "Microwave Range Hood Combo")]
		[XmlEnum(Name = "Microwave Range Hood Combo")]
		Microwave_Range_Hood_Combo = 47,

		[Display(Name = "Cooktop - Gas")]
		[XmlEnum(Name = "Cooktop - Gas")]
		Cooktop___Gas = 20,

		[Display(Name = "Cooktop - Electric")]
		[XmlEnum(Name = "Cooktop - Electric")]
		Cooktop___Electric = 19,

		[Display(Name = "Intercom")]
		[XmlEnum(Name = "Intercom")]
		Intercom = 18,

		[Display(Name = "Barbeque")]
		[XmlEnum(Name = "Barbeque")]
		Barbeque = 17,

		[Display(Name = "Whirlpool")]
		[XmlEnum(Name = "Whirlpool")]
		Whirlpool = 16,

		[Display(Name = "Jacuzzi")]
		[XmlEnum(Name = "Jacuzzi")]
		Jacuzzi = 15,

		[Display(Name = "Central Vacuum")]
		[XmlEnum(Name = "Central Vacuum")]
		Central_Vacuum = 14,

		[Display(Name = "Sauna")]
		[XmlEnum(Name = "Sauna")]
		Sauna = 13,

		[Display(Name = "Satellite Dish")]
		[XmlEnum(Name = "Satellite Dish")]
		Satellite_Dish = 12,

		[Display(Name = "Hot Tub")]
		[XmlEnum(Name = "Hot Tub")]
		Hot_Tub = 11,

		[Display(Name = "Water softener")]
		[XmlEnum(Name = "Water softener")]
		Water_softener = 10,

		[Display(Name = "Water purifier")]
		[XmlEnum(Name = "Water purifier")]
		Water_purifier = 9,

		[Display(Name = "Water meter")]
		[XmlEnum(Name = "Water meter")]
		Water_meter = 8,

		[Display(Name = "Oven - gas")]
		[XmlEnum(Name = "Oven - gas")]
		Oven___gas = 7,

		[Display(Name = "Oven - Electric")]
		[XmlEnum(Name = "Oven - Electric")]
		Oven___Electric = 6,

		[Display(Name = "Refrigerator")]
		[XmlEnum(Name = "Refrigerator")]
		Refrigerator = 5,

		[Display(Name = "Dryer - Gas")]
		[XmlEnum(Name = "Dryer - Gas")]
		Dryer___Gas = 4,

		[Display(Name = "Dryer - Electric")]
		[XmlEnum(Name = "Dryer - Electric")]
		Dryer___Electric = 3,

		[Display(Name = "Washer")]
		[XmlEnum(Name = "Washer")]
		Washer = 2,

		[Display(Name = "Cooktop - Propane")]
		[XmlEnum(Name = "Cooktop - Propane")]
		Cooktop___Propane = 21,

		[Display(Name = "Oven - Built-In")]
		[XmlEnum(Name = "Oven - Built-In")]
		Oven___Built_In = 48,

		[Display(Name = "Oven - Propane")]
		[XmlEnum(Name = "Oven - Propane")]
		Oven___Propane = 25,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 27,

		[Display(Name = "Garburator")]
		[XmlEnum(Name = "Garburator")]
		Garburator = 46,

		[Display(Name = "Freezer")]
		[XmlEnum(Name = "Freezer")]
		Freezer = 45,

		[Display(Name = "Compactor")]
		[XmlEnum(Name = "Compactor")]
		Compactor = 44,

		[Display(Name = "Cooktop")]
		[XmlEnum(Name = "Cooktop")]
		Cooktop = 43,

		[Display(Name = "Alarm System")]
		[XmlEnum(Name = "Alarm System")]
		Alarm_System = 42,

		[Display(Name = "2 Refrigerators & 2 Stoves")]
		[XmlEnum(Name = "2 Refrigerators & 2 Stoves")]
		_2_Refrigerators__2_Stoves = 41,

		[Display(Name = "Microwave")]
		[XmlEnum(Name = "Microwave")]
		Microwave = 40,

		[Display(Name = "Dryer")]
		[XmlEnum(Name = "Dryer")]
		Dryer = 39,

		[Display(Name = "Oven")]
		[XmlEnum(Name = "Oven")]
		Oven = 38,

		[Display(Name = "Range")]
		[XmlEnum(Name = "Range")]
		Range = 37,

		[Display(Name = "Stove")]
		[XmlEnum(Name = "Stove")]
		Stove = 36,

		[Display(Name = "Wine Fridge")]
		[XmlEnum(Name = "Wine Fridge")]
		Wine_Fridge = 35,

		[Display(Name = "Smart Box")]
		[XmlEnum(Name = "Smart Box")]
		Smart_Box = 34,

		[Display(Name = "Home Theatre")]
		[XmlEnum(Name = "Home Theatre")]
		Home_Theatre = 33,

		[Display(Name = "Wall Mounted TV")]
		[XmlEnum(Name = "Wall Mounted TV")]
		Wall_Mounted_TV = 32,

		[Display(Name = "Dishwasher")]
		[XmlEnum(Name = "Dishwasher")]
		Dishwasher = 31,

		[Display(Name = "Range - Electric")]
		[XmlEnum(Name = "Range - Electric")]
		Range___Electric = 30,

		[Display(Name = "Range - Gas")]
		[XmlEnum(Name = "Range - Gas")]
		Range___Gas = 29,

		[Display(Name = "Gas stove(s)")]
		[XmlEnum(Name = "Gas stove(s)")]
		Gas_stoves = 28,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 26,

		[Display(Name = "Water Heater")]
		[XmlEnum(Name = "Water Heater")]
		Water_Heater = 97
    }
}