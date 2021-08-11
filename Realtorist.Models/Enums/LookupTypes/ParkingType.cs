using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ParkingType
    {
		[Display(Name = "Attached Garage")]
		[XmlEnum(Name = "Attached Garage")]
		Attached_Garage = 1,

		[Display(Name = "RV")]
		[XmlEnum(Name = "RV")]
		RV = 22,

		[Display(Name = "Street")]
		[XmlEnum(Name = "Street")]
		Street = 23,

		[Display(Name = "Oversize")]
		[XmlEnum(Name = "Oversize")]
		Oversize = 24,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 25,

		[Display(Name = "Inside Entry")]
		[XmlEnum(Name = "Inside Entry")]
		Inside_Entry = 26,

		[Display(Name = "Gravel")]
		[XmlEnum(Name = "Gravel")]
		Gravel = 27,

		[Display(Name = "Interlocked")]
		[XmlEnum(Name = "Interlocked")]
		Interlocked = 28,

		[Display(Name = "Shared")]
		[XmlEnum(Name = "Shared")]
		Shared = 29,

		[Display(Name = "Street Permit")]
		[XmlEnum(Name = "Street Permit")]
		Street_Permit = 30,

		[Display(Name = "Surfaced")]
		[XmlEnum(Name = "Surfaced")]
		Surfaced = 31,

		[Display(Name = "Tandem")]
		[XmlEnum(Name = "Tandem")]
		Tandem = 32,

		[Display(Name = "Exposed Aggregate")]
		[XmlEnum(Name = "Exposed Aggregate")]
		Exposed_Aggregate = 33,

		[Display(Name = "Visitor Parking")]
		[XmlEnum(Name = "Visitor Parking")]
		Visitor_Parking = 34,

		[Display(Name = "Boat House")]
		[XmlEnum(Name = "Boat House")]
		Boat_House = 35,

		[Display(Name = "Concrete")]
		[XmlEnum(Name = "Concrete")]
		Concrete = 36,

		[Display(Name = "Rear")]
		[XmlEnum(Name = "Rear")]
		Rear = 21,

		[Display(Name = "Offset")]
		[XmlEnum(Name = "Offset")]
		Offset = 20,

		[Display(Name = "Breezeway")]
		[XmlEnum(Name = "Breezeway")]
		Breezeway = 19,

		[Display(Name = "Stall")]
		[XmlEnum(Name = "Stall")]
		Stall = 18,

		[Display(Name = "Integrated Garage")]
		[XmlEnum(Name = "Integrated Garage")]
		Integrated_Garage = 2,

		[Display(Name = "Detached Garage")]
		[XmlEnum(Name = "Detached Garage")]
		Detached_Garage = 3,

		[Display(Name = "Garage")]
		[XmlEnum(Name = "Garage")]
		Garage = 4,

		[Display(Name = "Carport")]
		[XmlEnum(Name = "Carport")]
		Carport = 5,

		[Display(Name = "Underground")]
		[XmlEnum(Name = "Underground")]
		Underground = 6,

		[Display(Name = "Indoor")]
		[XmlEnum(Name = "Indoor")]
		Indoor = 7,

		[Display(Name = "Open")]
		[XmlEnum(Name = "Open")]
		Open = 8,

		[Display(Name = "Heated Garage")]
		[XmlEnum(Name = "Heated Garage")]
		Heated_Garage = 37,

		[Display(Name = "Covered")]
		[XmlEnum(Name = "Covered")]
		Covered = 9,

		[Display(Name = "Paved Yard")]
		[XmlEnum(Name = "Paved Yard")]
		Paved_Yard = 11,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 12,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 13,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 14,

		[Display(Name = "No Garage")]
		[XmlEnum(Name = "No Garage")]
		No_Garage = 15,

		[Display(Name = "Parking Space(s)")]
		[XmlEnum(Name = "Parking Space(s)")]
		Parking_Spaces = 16,

		[Display(Name = "Parkade")]
		[XmlEnum(Name = "Parkade")]
		Parkade = 17,

		[Display(Name = "Parking Pad")]
		[XmlEnum(Name = "Parking Pad")]
		Parking_Pad = 10,

		[Display(Name = "Electric Vehicle Charging Station(s)")]
		[XmlEnum(Name = "Electric Vehicle Charging Station(s)")]
		Electric_Vehicle_Charging_Stations = 38
    }
}