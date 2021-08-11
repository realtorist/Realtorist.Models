using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum EquipmentType
    {
		[Display(Name = "Water Heater - Electric")]
		[XmlEnum(Name = "Water Heater - Electric")]
		Water_Heater___Electric = 1,

		[Display(Name = "Water Heater - Tankless")]
		[XmlEnum(Name = "Water Heater - Tankless")]
		Water_Heater___Tankless = 25,

		[Display(Name = "Water Softener")]
		[XmlEnum(Name = "Water Softener")]
		Water_Softener = 24,

		[Display(Name = "HRV")]
		[XmlEnum(Name = "HRV")]
		HRV = 23,

		[Display(Name = "Air Conditioner")]
		[XmlEnum(Name = "Air Conditioner")]
		Air_Conditioner = 22,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 21,

		[Display(Name = "Washer(s)")]
		[XmlEnum(Name = "Washer(s)")]
		Washers = 20,

		[Display(Name = "Stove(s)")]
		[XmlEnum(Name = "Stove(s)")]
		Stoves = 19,

		[Display(Name = "Fridge(s)")]
		[XmlEnum(Name = "Fridge(s)")]
		Fridges = 18,

		[Display(Name = "Dryer(s)")]
		[XmlEnum(Name = "Dryer(s)")]
		Dryers = 17,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 16,

		[Display(Name = "Water Heater")]
		[XmlEnum(Name = "Water Heater")]
		Water_Heater = 15,

		[Display(Name = "Heat Pump")]
		[XmlEnum(Name = "Heat Pump")]
		Heat_Pump = 26,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 14,

		[Display(Name = "Rental Stove - Gas")]
		[XmlEnum(Name = "Rental Stove - Gas")]
		Rental_Stove___Gas = 12,

		[Display(Name = "Rental Stove - Electric")]
		[XmlEnum(Name = "Rental Stove - Electric")]
		Rental_Stove___Electric = 11,

		[Display(Name = "Rental Fridge")]
		[XmlEnum(Name = "Rental Fridge")]
		Rental_Fridge = 10,

		[Display(Name = "Rental Dryer - Gas")]
		[XmlEnum(Name = "Rental Dryer - Gas")]
		Rental_Dryer___Gas = 9,

		[Display(Name = "Rental Dryer - Electric")]
		[XmlEnum(Name = "Rental Dryer - Electric")]
		Rental_Dryer___Electric = 8,

		[Display(Name = "Rental Washer")]
		[XmlEnum(Name = "Rental Washer")]
		Rental_Washer = 7,

		[Display(Name = "Propane Tank")]
		[XmlEnum(Name = "Propane Tank")]
		Propane_Tank = 6,

		[Display(Name = "Furnace")]
		[XmlEnum(Name = "Furnace")]
		Furnace = 5,

		[Display(Name = "Water Heater - Propane")]
		[XmlEnum(Name = "Water Heater - Propane")]
		Water_Heater___Propane = 4,

		[Display(Name = "Water Heater - Oil")]
		[XmlEnum(Name = "Water Heater - Oil")]
		Water_Heater___Oil = 3,

		[Display(Name = "Water Heater - Gas")]
		[XmlEnum(Name = "Water Heater - Gas")]
		Water_Heater___Gas = 2,

		[Display(Name = "Rental Water Softener")]
		[XmlEnum(Name = "Rental Water Softener")]
		Rental_Water_Softener = 13,

		[Display(Name = "Dusk to Dawn Light")]
		[XmlEnum(Name = "Dusk to Dawn Light")]
		Dusk_to_Dawn_Light = 27
    }
}