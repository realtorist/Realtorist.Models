using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum RoomType
    {
		[Display(Name = "Living room")]
		[XmlEnum(Name = "Living room")]
		Living_room = 1,

		[Display(Name = "Exercise room")]
		[XmlEnum(Name = "Exercise room")]
		Exercise_room = 81,

		[Display(Name = "Gym")]
		[XmlEnum(Name = "Gym")]
		Gym = 80,

		[Display(Name = "Recreation room")]
		[XmlEnum(Name = "Recreation room")]
		Recreation_room = 79,

		[Display(Name = "Eat in kitchen")]
		[XmlEnum(Name = "Eat in kitchen")]
		Eat_in_kitchen = 78,

		[Display(Name = "Sitting room")]
		[XmlEnum(Name = "Sitting room")]
		Sitting_room = 77,

		[Display(Name = "Sunroom/Fireplace")]
		[XmlEnum(Name = "Sunroom/Fireplace")]
		Sunroom_Fireplace = 75,

		[Display(Name = "Porch")]
		[XmlEnum(Name = "Porch")]
		Porch = 74,

		[Display(Name = "Living room/Fireplace")]
		[XmlEnum(Name = "Living room/Fireplace")]
		Living_room_Fireplace = 73,

		[Display(Name = "Family room/Fireplace")]
		[XmlEnum(Name = "Family room/Fireplace")]
		Family_room_Fireplace = 72,

		[Display(Name = "Florida room")]
		[XmlEnum(Name = "Florida room")]
		Florida_room = 71,

		[Display(Name = "Florida/Fireplace")]
		[XmlEnum(Name = "Florida/Fireplace")]
		Florida_Fireplace = 70,

		[Display(Name = "Fruit cellar")]
		[XmlEnum(Name = "Fruit cellar")]
		Fruit_cellar = 69,

		[Display(Name = "Balcony")]
		[XmlEnum(Name = "Balcony")]
		Balcony = 68,

		[Display(Name = "Games room")]
		[XmlEnum(Name = "Games room")]
		Games_room = 67,

		[Display(Name = "Playroom")]
		[XmlEnum(Name = "Playroom")]
		Playroom = 66,

		[Display(Name = "Attic (finished)")]
		[XmlEnum(Name = "Attic (finished)")]
		Attic_finished = 65,

		[Display(Name = "Sunroom")]
		[XmlEnum(Name = "Sunroom")]
		Sunroom = 64,

		[Display(Name = "Guest suite")]
		[XmlEnum(Name = "Guest suite")]
		Guest_suite = 63,

		[Display(Name = "Rental unit")]
		[XmlEnum(Name = "Rental unit")]
		Rental_unit = 62,

		[Display(Name = "In-law suite")]
		[XmlEnum(Name = "In-law suite")]
		In_law_suite = 61,

		[Display(Name = "Office")]
		[XmlEnum(Name = "Office")]
		Office = 60,

		[Display(Name = "Party room")]
		[XmlEnum(Name = "Party room")]
		Party_room = 59,

		[Display(Name = "Steam room")]
		[XmlEnum(Name = "Steam room")]
		Steam_room = 58,

		[Display(Name = "Ensuite")]
		[XmlEnum(Name = "Ensuite")]
		Ensuite = 82,

		[Display(Name = "Inlaw suite")]
		[XmlEnum(Name = "Inlaw suite")]
		Inlaw_suite = 83,

		[Display(Name = "Multi-use room")]
		[XmlEnum(Name = "Multi-use room")]
		Multi_use_room = 84,

		[Display(Name = "Lunchroom")]
		[XmlEnum(Name = "Lunchroom")]
		Lunchroom = 85,

		[Display(Name = "Second Kitchen")]
		[XmlEnum(Name = "Second Kitchen")]
		Second_Kitchen = 110,

		[Display(Name = "Photography-dark room")]
		[XmlEnum(Name = "Photography-dark room")]
		Photography_dark_room = 109,

		[Display(Name = "Bonus Room")]
		[XmlEnum(Name = "Bonus Room")]
		Bonus_Room = 108,

		[Display(Name = "Computer Room")]
		[XmlEnum(Name = "Computer Room")]
		Computer_Room = 107,

		[Display(Name = "Roughed-In Bathroom")]
		[XmlEnum(Name = "Roughed-In Bathroom")]
		Roughed_In_Bathroom = 106,

		[Display(Name = "Lobby")]
		[XmlEnum(Name = "Lobby")]
		Lobby = 105,

		[Display(Name = "Hall")]
		[XmlEnum(Name = "Hall")]
		Hall = 104,

		[Display(Name = "Bedroom - Bachelor")]
		[XmlEnum(Name = "Bedroom - Bachelor")]
		Bedroom___Bachelor = 103,

		[Display(Name = "Wine Cellar")]
		[XmlEnum(Name = "Wine Cellar")]
		Wine_Cellar = 102,

		[Display(Name = "Media")]
		[XmlEnum(Name = "Media")]
		Media = 101,

		[Display(Name = "Music")]
		[XmlEnum(Name = "Music")]
		Music = 100,

		[Display(Name = "6pc Ensuite bath")]
		[XmlEnum(Name = "6pc Ensuite bath")]
		_6pc_Ensuite_bath = 57,

		[Display(Name = "Muskoka Room")]
		[XmlEnum(Name = "Muskoka Room")]
		Muskoka_Room = 99,

		[Display(Name = "Attic")]
		[XmlEnum(Name = "Attic")]
		Attic = 96,

		[Display(Name = "Bathroom")]
		[XmlEnum(Name = "Bathroom")]
		Bathroom = 95,

		[Display(Name = "Beverage room")]
		[XmlEnum(Name = "Beverage room")]
		Beverage_room = 94,

		[Display(Name = "Study")]
		[XmlEnum(Name = "Study")]
		Study = 93,

		[Display(Name = "Pantry")]
		[XmlEnum(Name = "Pantry")]
		Pantry = 92,

		[Display(Name = "Furnace")]
		[XmlEnum(Name = "Furnace")]
		Furnace = 91,

		[Display(Name = "Nursery")]
		[XmlEnum(Name = "Nursery")]
		Nursery = 90,

		[Display(Name = "Breakfast")]
		[XmlEnum(Name = "Breakfast")]
		Breakfast = 89,

		[Display(Name = "Flat")]
		[XmlEnum(Name = "Flat")]
		Flat = 88,

		[Display(Name = "Not known")]
		[XmlEnum(Name = "Not known")]
		Not_known = 87,

		[Display(Name = "Mezzanine")]
		[XmlEnum(Name = "Mezzanine")]
		Mezzanine = 86,

		[Display(Name = "Walk Up Attic")]
		[XmlEnum(Name = "Walk Up Attic")]
		Walk_Up_Attic = 97,

		[Display(Name = "5pc Ensuite bath")]
		[XmlEnum(Name = "5pc Ensuite bath")]
		_5pc_Ensuite_bath = 56,

		[Display(Name = "4pc Ensuite bath")]
		[XmlEnum(Name = "4pc Ensuite bath")]
		_4pc_Ensuite_bath = 55,

		[Display(Name = "3pc Ensuite bath")]
		[XmlEnum(Name = "3pc Ensuite bath")]
		_3pc_Ensuite_bath = 54,

		[Display(Name = "Enclosed porch")]
		[XmlEnum(Name = "Enclosed porch")]
		Enclosed_porch = 25,

		[Display(Name = "Recreational, Games room")]
		[XmlEnum(Name = "Recreational, Games room")]
		Recreational_Games_room = 24,

		[Display(Name = "Partial ensuite bathroom")]
		[XmlEnum(Name = "Partial ensuite bathroom")]
		Partial_ensuite_bathroom = 23,

		[Display(Name = "Hobby room")]
		[XmlEnum(Name = "Hobby room")]
		Hobby_room = 22,

		[Display(Name = "Storage")]
		[XmlEnum(Name = "Storage")]
		Storage = 21,

		[Display(Name = "Foyer")]
		[XmlEnum(Name = "Foyer")]
		Foyer = 20,

		[Display(Name = "Full ensuite bathroom")]
		[XmlEnum(Name = "Full ensuite bathroom")]
		Full_ensuite_bathroom = 19,

		[Display(Name = "Full bathroom")]
		[XmlEnum(Name = "Full bathroom")]
		Full_bathroom = 18,

		[Display(Name = "Eating area")]
		[XmlEnum(Name = "Eating area")]
		Eating_area = 17,

		[Display(Name = "Conservatory")]
		[XmlEnum(Name = "Conservatory")]
		Conservatory = 16,

		[Display(Name = "Additional bedroom")]
		[XmlEnum(Name = "Additional bedroom")]
		Additional_bedroom = 15,

		[Display(Name = "Workshop")]
		[XmlEnum(Name = "Workshop")]
		Workshop = 26,

		[Display(Name = "Partial bathroom")]
		[XmlEnum(Name = "Partial bathroom")]
		Partial_bathroom = 14,

		[Display(Name = "Bedroom 6")]
		[XmlEnum(Name = "Bedroom 6")]
		Bedroom_6 = 12,

		[Display(Name = "Bedroom 5")]
		[XmlEnum(Name = "Bedroom 5")]
		Bedroom_5 = 11,

		[Display(Name = "Bedroom 4")]
		[XmlEnum(Name = "Bedroom 4")]
		Bedroom_4 = 10,

		[Display(Name = "Bedroom 3")]
		[XmlEnum(Name = "Bedroom 3")]
		Bedroom_3 = 9,

		[Display(Name = "Bedroom 2")]
		[XmlEnum(Name = "Bedroom 2")]
		Bedroom_2 = 8,

		[Display(Name = "Primary Bedroom")]
		[XmlEnum(Name = "Primary Bedroom")]
		Primary_Bedroom = 7,

		[Display(Name = "Family bathroom")]
		[XmlEnum(Name = "Family bathroom")]
		Family_bathroom = 6,

		[Display(Name = "Den")]
		[XmlEnum(Name = "Den")]
		Den = 5,

		[Display(Name = "Family room")]
		[XmlEnum(Name = "Family room")]
		Family_room = 4,

		[Display(Name = "Kitchen")]
		[XmlEnum(Name = "Kitchen")]
		Kitchen = 3,

		[Display(Name = "Dining room")]
		[XmlEnum(Name = "Dining room")]
		Dining_room = 2,

		[Display(Name = "Laundry room")]
		[XmlEnum(Name = "Laundry room")]
		Laundry_room = 13,

		[Display(Name = "Laundry / Bath")]
		[XmlEnum(Name = "Laundry / Bath")]
		Laundry___Bath = 111,

		[Display(Name = "Utility room")]
		[XmlEnum(Name = "Utility room")]
		Utility_room = 27,

		[Display(Name = "Living room/Dining room")]
		[XmlEnum(Name = "Living room/Dining room")]
		Living_room_Dining_room = 29,

		[Display(Name = "2pc Ensuite bath")]
		[XmlEnum(Name = "2pc Ensuite bath")]
		_2pc_Ensuite_bath = 53,

		[Display(Name = "1pc Ensuite bath")]
		[XmlEnum(Name = "1pc Ensuite bath")]
		_1pc_Ensuite_bath = 52,

		[Display(Name = "6pc Bathroom")]
		[XmlEnum(Name = "6pc Bathroom")]
		_6pc_Bathroom = 51,

		[Display(Name = "5pc Bathroom")]
		[XmlEnum(Name = "5pc Bathroom")]
		_5pc_Bathroom = 50,

		[Display(Name = "4pc Bathroom")]
		[XmlEnum(Name = "4pc Bathroom")]
		_4pc_Bathroom = 49,

		[Display(Name = "3pc Bathroom")]
		[XmlEnum(Name = "3pc Bathroom")]
		_3pc_Bathroom = 48,

		[Display(Name = "2pc Bathroom")]
		[XmlEnum(Name = "2pc Bathroom")]
		_2pc_Bathroom = 47,

		[Display(Name = "1pc Bathroom")]
		[XmlEnum(Name = "1pc Bathroom")]
		_1pc_Bathroom = 46,

		[Display(Name = "Library")]
		[XmlEnum(Name = "Library")]
		Library = 45,

		[Display(Name = "Sauna")]
		[XmlEnum(Name = "Sauna")]
		Sauna = 44,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 43,

		[Display(Name = "Solarium")]
		[XmlEnum(Name = "Solarium")]
		Solarium = 28,

		[Display(Name = "Mud room")]
		[XmlEnum(Name = "Mud room")]
		Mud_room = 42,

		[Display(Name = "Kitchen/Dining room")]
		[XmlEnum(Name = "Kitchen/Dining room")]
		Kitchen_Dining_room = 40,

		[Display(Name = "Jacuzzi")]
		[XmlEnum(Name = "Jacuzzi")]
		Jacuzzi = 39,

		[Display(Name = "Great room")]
		[XmlEnum(Name = "Great room")]
		Great_room = 38,

		[Display(Name = "Ensuite (# pieces 2-6)")]
		[XmlEnum(Name = "Ensuite (# pieces 2-6)")]
		Ensuite__pieces_2_6 = 37,

		[Display(Name = "Dining nook")]
		[XmlEnum(Name = "Dining nook")]
		Dining_nook = 36,

		[Display(Name = "Dinette")]
		[XmlEnum(Name = "Dinette")]
		Dinette = 35,

		[Display(Name = "Cold room")]
		[XmlEnum(Name = "Cold room")]
		Cold_room = 34,

		[Display(Name = "Bedroom")]
		[XmlEnum(Name = "Bedroom")]
		Bedroom = 33,

		[Display(Name = "Bath (# pieces 1-6)")]
		[XmlEnum(Name = "Bath (# pieces 1-6)")]
		Bath__pieces_1_6 = 32,

		[Display(Name = "Atrium")]
		[XmlEnum(Name = "Atrium")]
		Atrium = 31,

		[Display(Name = "Addition")]
		[XmlEnum(Name = "Addition")]
		Addition = 30,

		[Display(Name = "Loft")]
		[XmlEnum(Name = "Loft")]
		Loft = 41,

		[Display(Name = "Flex Space")]
		[XmlEnum(Name = "Flex Space")]
		Flex_Space = 112
    }
}