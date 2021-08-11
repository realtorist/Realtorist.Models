using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum HeatingFuel
    {
		[Display(Name = "Oil")]
		[XmlEnum(Name = "Oil")]
		Oil = 20,

		[Display(Name = "Geo Thermal")]
		[XmlEnum(Name = "Geo Thermal")]
		Geo_Thermal = 35,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 34,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 33,

		[Display(Name = "Bi energy")]
		[XmlEnum(Name = "Bi energy")]
		Bi_energy = 32,

		[Display(Name = "Coal")]
		[XmlEnum(Name = "Coal")]
		Coal = 31,

		[Display(Name = "Pellet")]
		[XmlEnum(Name = "Pellet")]
		Pellet = 30,

		[Display(Name = "Wood")]
		[XmlEnum(Name = "Wood")]
		Wood = 29,

		[Display(Name = "Solar")]
		[XmlEnum(Name = "Solar")]
		Solar = 28,

		[Display(Name = "Combination")]
		[XmlEnum(Name = "Combination")]
		Combination = 27,

		[Display(Name = "Propane")]
		[XmlEnum(Name = "Propane")]
		Propane = 26,

		[Display(Name = "Natural gas")]
		[XmlEnum(Name = "Natural gas")]
		Natural_gas = 25,

		[Display(Name = "Electric")]
		[XmlEnum(Name = "Electric")]
		Electric = 24,

		[Display(Name = "Waste oil")]
		[XmlEnum(Name = "Waste oil")]
		Waste_oil = 23,

		[Display(Name = "Stove oil")]
		[XmlEnum(Name = "Stove oil")]
		Stove_oil = 22,

		[Display(Name = "Heating oil")]
		[XmlEnum(Name = "Heating oil")]
		Heating_oil = 21,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 36,

		[Display(Name = "Wind Power")]
		[XmlEnum(Name = "Wind Power")]
		Wind_Power = 37
    }
}