using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum LandscapeFeatures
    {
		[Display(Name = "Landscaped")]
		[XmlEnum(Name = "Landscaped")]
		Landscaped = 1,

		[Display(Name = "Sprinkler")]
		[XmlEnum(Name = "Sprinkler")]
		Sprinkler = 15,

		[Display(Name = "Sprinkler system")]
		[XmlEnum(Name = "Sprinkler system")]
		Sprinkler_system = 14,

		[Display(Name = "Underground sprinkler")]
		[XmlEnum(Name = "Underground sprinkler")]
		Underground_sprinkler = 13,

		[Display(Name = "Lawn sprinkler")]
		[XmlEnum(Name = "Lawn sprinkler")]
		Lawn_sprinkler = 12,

		[Display(Name = "Irrigation sprinkler(s)")]
		[XmlEnum(Name = "Irrigation sprinkler(s)")]
		Irrigation_sprinklers = 11,

		[Display(Name = "Fully landscaped")]
		[XmlEnum(Name = "Fully landscaped")]
		Fully_landscaped = 10,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 16,

		[Display(Name = "Fruit trees")]
		[XmlEnum(Name = "Fruit trees")]
		Fruit_trees = 9,

		[Display(Name = "Garden Area")]
		[XmlEnum(Name = "Garden Area")]
		Garden_Area = 7,

		[Display(Name = "Lawn")]
		[XmlEnum(Name = "Lawn")]
		Lawn = 6,

		[Display(Name = "Not landscaped")]
		[XmlEnum(Name = "Not landscaped")]
		Not_landscaped = 5,

		[Display(Name = "Partially landscaped")]
		[XmlEnum(Name = "Partially landscaped")]
		Partially_landscaped = 4,

		[Display(Name = "Vegetable garden")]
		[XmlEnum(Name = "Vegetable garden")]
		Vegetable_garden = 3,

		[Display(Name = "Fruit trees/shrubs")]
		[XmlEnum(Name = "Fruit trees/shrubs")]
		Fruit_trees_shrubs = 2,

		[Display(Name = "Land / Yard lined with hedges")]
		[XmlEnum(Name = "Land / Yard lined with hedges")]
		Land___Yard_lined_with_hedges = 8,

		[Display(Name = "Xeriscaping")]
		[XmlEnum(Name = "Xeriscaping")]
		Xeriscaping = 17
    }
}