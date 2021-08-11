using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Machinery
    {
		[Display(Name = "Tractor")]
		[XmlEnum(Name = "Tractor")]
		Tractor = 1,

		[Display(Name = "Container Lift Crane")]
		[XmlEnum(Name = "Container Lift Crane")]
		Container_Lift_Crane = 19,

		[Display(Name = "Forklift")]
		[XmlEnum(Name = "Forklift")]
		Forklift = 18,

		[Display(Name = "Overhead Crane")]
		[XmlEnum(Name = "Overhead Crane")]
		Overhead_Crane = 17,

		[Display(Name = "Manure Spreader")]
		[XmlEnum(Name = "Manure Spreader")]
		Manure_Spreader = 16,

		[Display(Name = "Fertilizer Spreader")]
		[XmlEnum(Name = "Fertilizer Spreader")]
		Fertilizer_Spreader = 15,

		[Display(Name = "Hay Elevator")]
		[XmlEnum(Name = "Hay Elevator")]
		Hay_Elevator = 14,

		[Display(Name = "Grain Auger")]
		[XmlEnum(Name = "Grain Auger")]
		Grain_Auger = 13,

		[Display(Name = "Bale Thrower")]
		[XmlEnum(Name = "Bale Thrower")]
		Bale_Thrower = 12,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 20,

		[Display(Name = "Round Bailer")]
		[XmlEnum(Name = "Round Bailer")]
		Round_Bailer = 11,

		[Display(Name = "Small Square Bailer")]
		[XmlEnum(Name = "Small Square Bailer")]
		Small_Square_Bailer = 9,

		[Display(Name = "Sprayer")]
		[XmlEnum(Name = "Sprayer")]
		Sprayer = 8,

		[Display(Name = "Livestock Truck")]
		[XmlEnum(Name = "Livestock Truck")]
		Livestock_Truck = 7,

		[Display(Name = "Livestock Trailer")]
		[XmlEnum(Name = "Livestock Trailer")]
		Livestock_Trailer = 6,

		[Display(Name = "Hay Wagon")]
		[XmlEnum(Name = "Hay Wagon")]
		Hay_Wagon = 5,

		[Display(Name = "Gravity Box")]
		[XmlEnum(Name = "Gravity Box")]
		Gravity_Box = 4,

		[Display(Name = "Skid Steer")]
		[XmlEnum(Name = "Skid Steer")]
		Skid_Steer = 3,

		[Display(Name = "Combine")]
		[XmlEnum(Name = "Combine")]
		Combine = 2,

		[Display(Name = "Large Square Bailer")]
		[XmlEnum(Name = "Large Square Bailer")]
		Large_Square_Bailer = 10,

		[Display(Name = "All")]
		[XmlEnum(Name = "All")]
		All = 21
    }
}