using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Crop
    {
		[Display(Name = "Barley")]
		[XmlEnum(Name = "Barley")]
		Barley = 1,

		[Display(Name = "Tomatoes")]
		[XmlEnum(Name = "Tomatoes")]
		Tomatoes = 26,

		[Display(Name = "Grapes")]
		[XmlEnum(Name = "Grapes")]
		Grapes = 27,

		[Display(Name = "Mushrooms")]
		[XmlEnum(Name = "Mushrooms")]
		Mushrooms = 28,

		[Display(Name = "Berries")]
		[XmlEnum(Name = "Berries")]
		Berries = 29,

		[Display(Name = "Strawberries")]
		[XmlEnum(Name = "Strawberries")]
		Strawberries = 30,

		[Display(Name = "Raspberries")]
		[XmlEnum(Name = "Raspberries")]
		Raspberries = 31,

		[Display(Name = "Blueberries")]
		[XmlEnum(Name = "Blueberries")]
		Blueberries = 32,

		[Display(Name = "Melons")]
		[XmlEnum(Name = "Melons")]
		Melons = 33,

		[Display(Name = "Pumpkins")]
		[XmlEnum(Name = "Pumpkins")]
		Pumpkins = 34,

		[Display(Name = "Peppers")]
		[XmlEnum(Name = "Peppers")]
		Peppers = 35,

		[Display(Name = "Apples")]
		[XmlEnum(Name = "Apples")]
		Apples = 36,

		[Display(Name = "Pears")]
		[XmlEnum(Name = "Pears")]
		Pears = 37,

		[Display(Name = "Plums")]
		[XmlEnum(Name = "Plums")]
		Plums = 38,

		[Display(Name = "Cherries")]
		[XmlEnum(Name = "Cherries")]
		Cherries = 39,

		[Display(Name = "Cranberries")]
		[XmlEnum(Name = "Cranberries")]
		Cranberries = 40,

		[Display(Name = "Tree")]
		[XmlEnum(Name = "Tree")]
		Tree = 41,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 42,

		[Display(Name = "Vegetable & Fruit")]
		[XmlEnum(Name = "Vegetable & Fruit")]
		Vegetable__Fruit = 43,

		[Display(Name = "Alfalfa")]
		[XmlEnum(Name = "Alfalfa")]
		Alfalfa = 44,

		[Display(Name = "Sugar Beets")]
		[XmlEnum(Name = "Sugar Beets")]
		Sugar_Beets = 25,

		[Display(Name = "Canola")]
		[XmlEnum(Name = "Canola")]
		Canola = 45,

		[Display(Name = "Potatoes")]
		[XmlEnum(Name = "Potatoes")]
		Potatoes = 23,

		[Display(Name = "Onions")]
		[XmlEnum(Name = "Onions")]
		Onions = 21,

		[Display(Name = "Beans")]
		[XmlEnum(Name = "Beans")]
		Beans = 2,

		[Display(Name = "Corn")]
		[XmlEnum(Name = "Corn")]
		Corn = 3,

		[Display(Name = "Sweet Corn")]
		[XmlEnum(Name = "Sweet Corn")]
		Sweet_Corn = 4,

		[Display(Name = "Hay")]
		[XmlEnum(Name = "Hay")]
		Hay = 5,

		[Display(Name = "Hops")]
		[XmlEnum(Name = "Hops")]
		Hops = 6,

		[Display(Name = "Kale/Cole")]
		[XmlEnum(Name = "Kale/Cole")]
		Kale_Cole = 7,

		[Display(Name = "Oats")]
		[XmlEnum(Name = "Oats")]
		Oats = 8,

		[Display(Name = "Soybeans")]
		[XmlEnum(Name = "Soybeans")]
		Soybeans = 9,

		[Display(Name = "Wheat")]
		[XmlEnum(Name = "Wheat")]
		Wheat = 10,

		[Display(Name = "Rice")]
		[XmlEnum(Name = "Rice")]
		Rice = 11,

		[Display(Name = "Grains")]
		[XmlEnum(Name = "Grains")]
		Grains = 12,

		[Display(Name = "Tobacco")]
		[XmlEnum(Name = "Tobacco")]
		Tobacco = 13,

		[Display(Name = "Sod")]
		[XmlEnum(Name = "Sod")]
		Sod = 14,

		[Display(Name = "Fruits")]
		[XmlEnum(Name = "Fruits")]
		Fruits = 15,

		[Display(Name = "Mixed Vegetables")]
		[XmlEnum(Name = "Mixed Vegetables")]
		Mixed_Vegetables = 16,

		[Display(Name = "Plants/Flowers")]
		[XmlEnum(Name = "Plants/Flowers")]
		Plants_Flowers = 17,

		[Display(Name = "Herbs")]
		[XmlEnum(Name = "Herbs")]
		Herbs = 18,

		[Display(Name = "Carrots")]
		[XmlEnum(Name = "Carrots")]
		Carrots = 19,

		[Display(Name = "Cucumbers")]
		[XmlEnum(Name = "Cucumbers")]
		Cucumbers = 20,

		[Display(Name = "Pea Crops")]
		[XmlEnum(Name = "Pea Crops")]
		Pea_Crops = 22,

		[Display(Name = "Cannabis")]
		[XmlEnum(Name = "Cannabis")]
		Cannabis = 46
    }
}