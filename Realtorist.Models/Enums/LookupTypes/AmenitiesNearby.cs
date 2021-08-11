using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum AmenitiesNearby
    {
		[Display(Name = "Golf Course")]
		[XmlEnum(Name = "Golf Course")]
		Golf_Course = 1,

		[Display(Name = "Outdoor Skating Rink")]
		[XmlEnum(Name = "Outdoor Skating Rink")]
		Outdoor_Skating_Rink = 27,

		[Display(Name = "Place of Worship")]
		[XmlEnum(Name = "Place of Worship")]
		Place_of_Worship = 26,

		[Display(Name = "Walking Trails")]
		[XmlEnum(Name = "Walking Trails")]
		Walking_Trails = 25,

		[Display(Name = "Recreation Nearby")]
		[XmlEnum(Name = "Recreation Nearby")]
		Recreation_Nearby = 24,

		[Display(Name = "Railway")]
		[XmlEnum(Name = "Railway")]
		Railway = 23,

		[Display(Name = "Golf Nearby")]
		[XmlEnum(Name = "Golf Nearby")]
		Golf_Nearby = 22,

		[Display(Name = "Water Nearby")]
		[XmlEnum(Name = "Water Nearby")]
		Water_Nearby = 21,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 20,

		[Display(Name = "Ski area")]
		[XmlEnum(Name = "Ski area")]
		Ski_area = 19,

		[Display(Name = "School yard")]
		[XmlEnum(Name = "School yard")]
		School_yard = 18,

		[Display(Name = "Stores")]
		[XmlEnum(Name = "Stores")]
		Stores = 17,

		[Display(Name = "University")]
		[XmlEnum(Name = "University")]
		University = 16,

		[Display(Name = "Public Transit")]
		[XmlEnum(Name = "Public Transit")]
		Public_Transit = 14,

		[Display(Name = "Hospital")]
		[XmlEnum(Name = "Hospital")]
		Hospital = 13,

		[Display(Name = "Church")]
		[XmlEnum(Name = "Church")]
		Church = 12,

		[Display(Name = "CEGEP")]
		[XmlEnum(Name = "CEGEP")]
		CEGEP = 11,

		[Display(Name = "Marina")]
		[XmlEnum(Name = "Marina")]
		Marina = 10,

		[Display(Name = "Park")]
		[XmlEnum(Name = "Park")]
		Park = 9,

		[Display(Name = "Highway")]
		[XmlEnum(Name = "Highway")]
		Highway = 8,

		[Display(Name = "Schools")]
		[XmlEnum(Name = "Schools")]
		Schools = 7,

		[Display(Name = "Ski hill")]
		[XmlEnum(Name = "Ski hill")]
		Ski_hill = 6,

		[Display(Name = "Playground")]
		[XmlEnum(Name = "Playground")]
		Playground = 5,

		[Display(Name = "Airport")]
		[XmlEnum(Name = "Airport")]
		Airport = 4,

		[Display(Name = "Shopping")]
		[XmlEnum(Name = "Shopping")]
		Shopping = 3,

		[Display(Name = "Recreation")]
		[XmlEnum(Name = "Recreation")]
		Recreation = 2,

		[Display(Name = "Indoor Skating Rink")]
		[XmlEnum(Name = "Indoor Skating Rink")]
		Indoor_Skating_Rink = 28,

		[Display(Name = "Beach")]
		[XmlEnum(Name = "Beach")]
		Beach = 29
    }
}