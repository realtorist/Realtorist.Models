using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum CoolingType
    {
		[Display(Name = "Central air conditioning")]
		[XmlEnum(Name = "Central air conditioning")]
		Central_air_conditioning = 1,

		[Display(Name = "Fully air conditioned")]
		[XmlEnum(Name = "Fully air conditioned")]
		Fully_air_conditioned = 6,

		[Display(Name = "Partially air conditioned")]
		[XmlEnum(Name = "Partially air conditioned")]
		Partially_air_conditioned = 2,

		[Display(Name = "Ventilation system")]
		[XmlEnum(Name = "Ventilation system")]
		Ventilation_system = 5,

		[Display(Name = "Window air conditioner")]
		[XmlEnum(Name = "Window air conditioner")]
		Window_air_conditioner = 3,

		[Display(Name = "Wall unit")]
		[XmlEnum(Name = "Wall unit")]
		Wall_unit = 7,

		[Display(Name = "Air exchanger")]
		[XmlEnum(Name = "Air exchanger")]
		Air_exchanger = 4,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 8,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 9,

		[Display(Name = "Heat Pump")]
		[XmlEnum(Name = "Heat Pump")]
		Heat_Pump = 10,

		[Display(Name = "Air Conditioned")]
		[XmlEnum(Name = "Air Conditioned")]
		Air_Conditioned = 11,

		[Display(Name = "Ductless")]
		[XmlEnum(Name = "Ductless")]
		Ductless = 12,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 13
    }
}