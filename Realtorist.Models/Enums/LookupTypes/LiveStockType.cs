using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum LiveStockType
    {
		[Display(Name = "Beef")]
		[XmlEnum(Name = "Beef")]
		Beef = 1,

		[Display(Name = "Cat")]
		[XmlEnum(Name = "Cat")]
		Cat = 23,

		[Display(Name = "Salmon")]
		[XmlEnum(Name = "Salmon")]
		Salmon = 24,

		[Display(Name = "Game Fish")]
		[XmlEnum(Name = "Game Fish")]
		Game_Fish = 25,

		[Display(Name = "Shellfish")]
		[XmlEnum(Name = "Shellfish")]
		Shellfish = 26,

		[Display(Name = "Mussells")]
		[XmlEnum(Name = "Mussells")]
		Mussells = 27,

		[Display(Name = "Clams")]
		[XmlEnum(Name = "Clams")]
		Clams = 28,

		[Display(Name = "Scallops")]
		[XmlEnum(Name = "Scallops")]
		Scallops = 29,

		[Display(Name = "Dog")]
		[XmlEnum(Name = "Dog")]
		Dog = 22,

		[Display(Name = "Snails")]
		[XmlEnum(Name = "Snails")]
		Snails = 30,

		[Display(Name = "Mink")]
		[XmlEnum(Name = "Mink")]
		Mink = 32,

		[Display(Name = "Fox")]
		[XmlEnum(Name = "Fox")]
		Fox = 33,

		[Display(Name = "Fish")]
		[XmlEnum(Name = "Fish")]
		Fish = 34,

		[Display(Name = "Poultry")]
		[XmlEnum(Name = "Poultry")]
		Poultry = 35,

		[Display(Name = "Dairy")]
		[XmlEnum(Name = "Dairy")]
		Dairy = 36,

		[Display(Name = "Exotic Animals")]
		[XmlEnum(Name = "Exotic Animals")]
		Exotic_Animals = 37,

		[Display(Name = "Stock included")]
		[XmlEnum(Name = "Stock included")]
		Stock_included = 38,

		[Display(Name = "Chinchilla")]
		[XmlEnum(Name = "Chinchilla")]
		Chinchilla = 31,

		[Display(Name = "Bee")]
		[XmlEnum(Name = "Bee")]
		Bee = 21,

		[Display(Name = "Pidgeon")]
		[XmlEnum(Name = "Pidgeon")]
		Pidgeon = 20,

		[Display(Name = "Quail")]
		[XmlEnum(Name = "Quail")]
		Quail = 19,

		[Display(Name = "Calf")]
		[XmlEnum(Name = "Calf")]
		Calf = 2,

		[Display(Name = "Cow")]
		[XmlEnum(Name = "Cow")]
		Cow = 3,

		[Display(Name = "Goat")]
		[XmlEnum(Name = "Goat")]
		Goat = 4,

		[Display(Name = "Hog")]
		[XmlEnum(Name = "Hog")]
		Hog = 5,

		[Display(Name = "Horse")]
		[XmlEnum(Name = "Horse")]
		Horse = 6,

		[Display(Name = "Rabbit")]
		[XmlEnum(Name = "Rabbit")]
		Rabbit = 7,

		[Display(Name = "Sheep")]
		[XmlEnum(Name = "Sheep")]
		Sheep = 8,

		[Display(Name = "Worm")]
		[XmlEnum(Name = "Worm")]
		Worm = 9,

		[Display(Name = "Alpaca")]
		[XmlEnum(Name = "Alpaca")]
		Alpaca = 10,

		[Display(Name = "Deer")]
		[XmlEnum(Name = "Deer")]
		Deer = 11,

		[Display(Name = "Elk")]
		[XmlEnum(Name = "Elk")]
		Elk = 12,

		[Display(Name = "Buffalo")]
		[XmlEnum(Name = "Buffalo")]
		Buffalo = 13,

		[Display(Name = "Chicken")]
		[XmlEnum(Name = "Chicken")]
		Chicken = 14,

		[Display(Name = "Turkey")]
		[XmlEnum(Name = "Turkey")]
		Turkey = 15,

		[Display(Name = "Duck")]
		[XmlEnum(Name = "Duck")]
		Duck = 16,

		[Display(Name = "Goose")]
		[XmlEnum(Name = "Goose")]
		Goose = 17,

		[Display(Name = "Pheasant")]
		[XmlEnum(Name = "Pheasant")]
		Pheasant = 18,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 39,

		[Display(Name = "Stock Not Included")]
		[XmlEnum(Name = "Stock Not Included")]
		Stock_Not_Included = 40
    }
}