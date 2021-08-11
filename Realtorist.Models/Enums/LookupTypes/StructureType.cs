using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum StructureType
    {
		[Display(Name = "Sidewalk")]
		[XmlEnum(Name = "Sidewalk")]
		Sidewalk = 1,

		[Display(Name = "Paddocks/Corralls")]
		[XmlEnum(Name = "Paddocks/Corralls")]
		Paddocks_Corralls = 28,

		[Display(Name = "Milk Parlour")]
		[XmlEnum(Name = "Milk Parlour")]
		Milk_Parlour = 29,

		[Display(Name = "Pole Barn")]
		[XmlEnum(Name = "Pole Barn")]
		Pole_Barn = 30,

		[Display(Name = "Drive Shed")]
		[XmlEnum(Name = "Drive Shed")]
		Drive_Shed = 31,

		[Display(Name = "Silo")]
		[XmlEnum(Name = "Silo")]
		Silo = 32,

		[Display(Name = "Coverall")]
		[XmlEnum(Name = "Coverall")]
		Coverall = 33,

		[Display(Name = "Dog Run - Fenced In")]
		[XmlEnum(Name = "Dog Run - Fenced In")]
		Dog_Run___Fenced_In = 34,

		[Display(Name = "Fire Pit")]
		[XmlEnum(Name = "Fire Pit")]
		Fire_Pit = 35,

		[Display(Name = "Labour Housing")]
		[XmlEnum(Name = "Labour Housing")]
		Labour_Housing = 37,

		[Display(Name = "Barn")]
		[XmlEnum(Name = "Barn")]
		Barn = 38,

		[Display(Name = "Building")]
		[XmlEnum(Name = "Building")]
		Building = 39,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 36,

		[Display(Name = "Plane Hangar")]
		[XmlEnum(Name = "Plane Hangar")]
		Plane_Hangar = 40,

		[Display(Name = "Crop")]
		[XmlEnum(Name = "Crop")]
		Crop = 41,

		[Display(Name = "Livestock")]
		[XmlEnum(Name = "Livestock")]
		Livestock = 42,

		[Display(Name = "Machinery")]
		[XmlEnum(Name = "Machinery")]
		Machinery = 43,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 44,

		[Display(Name = "Arena")]
		[XmlEnum(Name = "Arena")]
		Arena = 45,

		[Display(Name = "Concrete Silo")]
		[XmlEnum(Name = "Concrete Silo")]
		Concrete_Silo = 46,

		[Display(Name = "See Remarks")]
		[XmlEnum(Name = "See Remarks")]
		See_Remarks = 47,

		[Display(Name = "Steel Silo")]
		[XmlEnum(Name = "Steel Silo")]
		Steel_Silo = 48,

		[Display(Name = "Frame Barn")]
		[XmlEnum(Name = "Frame Barn")]
		Frame_Barn = 27,

		[Display(Name = "Equestrian Track")]
		[XmlEnum(Name = "Equestrian Track")]
		Equestrian_Track = 26,

		[Display(Name = "Equestrian Arena")]
		[XmlEnum(Name = "Equestrian Arena")]
		Equestrian_Arena = 25,

		[Display(Name = "Bank Barn")]
		[XmlEnum(Name = "Bank Barn")]
		Bank_Barn = 24,

		[Display(Name = "Dock")]
		[XmlEnum(Name = "Dock")]
		Dock = 2,

		[Display(Name = "Patio(s)")]
		[XmlEnum(Name = "Patio(s)")]
		Patios = 3,

		[Display(Name = "Sundeck")]
		[XmlEnum(Name = "Sundeck")]
		Sundeck = 4,

		[Display(Name = "Breakwater")]
		[XmlEnum(Name = "Breakwater")]
		Breakwater = 5,

		[Display(Name = "Deck")]
		[XmlEnum(Name = "Deck")]
		Deck = 6,

		[Display(Name = "Concrete terrace")]
		[XmlEnum(Name = "Concrete terrace")]
		Concrete_terrace = 7,

		[Display(Name = "Wood terrace")]
		[XmlEnum(Name = "Wood terrace")]
		Wood_terrace = 8,

		[Display(Name = "Squash & Raquet Court")]
		[XmlEnum(Name = "Squash & Raquet Court")]
		Squash__Raquet_Court = 9,

		[Display(Name = "Tennis Court")]
		[XmlEnum(Name = "Tennis Court")]
		Tennis_Court = 10,

		[Display(Name = "Playground")]
		[XmlEnum(Name = "Playground")]
		Playground = 11,

		[Display(Name = "Track")]
		[XmlEnum(Name = "Track")]
		Track = 49,

		[Display(Name = "Breakwall")]
		[XmlEnum(Name = "Breakwall")]
		Breakwall = 12,

		[Display(Name = "Playstructure")]
		[XmlEnum(Name = "Playstructure")]
		Playstructure = 14,

		[Display(Name = "Outbuilding")]
		[XmlEnum(Name = "Outbuilding")]
		Outbuilding = 15,

		[Display(Name = "Workshop")]
		[XmlEnum(Name = "Workshop")]
		Workshop = 16,

		[Display(Name = "Shed")]
		[XmlEnum(Name = "Shed")]
		Shed = 17,

		[Display(Name = "Boathouse")]
		[XmlEnum(Name = "Boathouse")]
		Boathouse = 18,

		[Display(Name = "Greenhouse")]
		[XmlEnum(Name = "Greenhouse")]
		Greenhouse = 19,

		[Display(Name = "Atrium")]
		[XmlEnum(Name = "Atrium")]
		Atrium = 20,

		[Display(Name = "Clubhouse")]
		[XmlEnum(Name = "Clubhouse")]
		Clubhouse = 21,

		[Display(Name = "Playhouse")]
		[XmlEnum(Name = "Playhouse")]
		Playhouse = 22,

		[Display(Name = "Porch")]
		[XmlEnum(Name = "Porch")]
		Porch = 23,

		[Display(Name = "Wharf")]
		[XmlEnum(Name = "Wharf")]
		Wharf = 13,

		[Display(Name = "Track House")]
		[XmlEnum(Name = "Track House")]
		Track_House = 50
    }
}