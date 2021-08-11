using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum CommunityFeatures
    {
		[Display(Name = "Adult Oriented")]
		[XmlEnum(Name = "Adult Oriented")]
		Adult_Oriented = 1,

		[Display(Name = "Rentals Not Allowed")]
		[XmlEnum(Name = "Rentals Not Allowed")]
		Rentals_Not_Allowed = 25,

		[Display(Name = "Rentals Allowed")]
		[XmlEnum(Name = "Rentals Allowed")]
		Rentals_Allowed = 24,

		[Display(Name = "Pets Allowed With Restrictions")]
		[XmlEnum(Name = "Pets Allowed With Restrictions")]
		Pets_Allowed_With_Restrictions = 23,

		[Display(Name = "Pet Restrictions")]
		[XmlEnum(Name = "Pet Restrictions")]
		Pet_Restrictions = 22,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 21,

		[Display(Name = "High Population Density")]
		[XmlEnum(Name = "High Population Density")]
		High_Population_Density = 20,

		[Display(Name = "Recreational Facilities")]
		[XmlEnum(Name = "Recreational Facilities")]
		Recreational_Facilities = 19,

		[Display(Name = "Public Washrooms")]
		[XmlEnum(Name = "Public Washrooms")]
		Public_Washrooms = 18,

		[Display(Name = "Industrial Park")]
		[XmlEnum(Name = "Industrial Park")]
		Industrial_Park = 17,

		[Display(Name = "Fishing")]
		[XmlEnum(Name = "Fishing")]
		Fishing = 16,

		[Display(Name = "Community Centre")]
		[XmlEnum(Name = "Community Centre")]
		Community_Centre = 15,

		[Display(Name = "Rentals Allowed With Restrictions")]
		[XmlEnum(Name = "Rentals Allowed With Restrictions")]
		Rentals_Allowed_With_Restrictions = 26,

		[Display(Name = "Bus Route")]
		[XmlEnum(Name = "Bus Route")]
		Bus_Route = 14,

		[Display(Name = "Public Swimming Pool")]
		[XmlEnum(Name = "Public Swimming Pool")]
		Public_Swimming_Pool = 12,

		[Display(Name = "School Bus")]
		[XmlEnum(Name = "School Bus")]
		School_Bus = 11,

		[Display(Name = "Lake Privileges")]
		[XmlEnum(Name = "Lake Privileges")]
		Lake_Privileges = 10,

		[Display(Name = "High Traffic Area")]
		[XmlEnum(Name = "High Traffic Area")]
		High_Traffic_Area = 9,

		[Display(Name = "Seniors Oriented")]
		[XmlEnum(Name = "Seniors Oriented")]
		Seniors_Oriented = 8,

		[Display(Name = "Rural Setting")]
		[XmlEnum(Name = "Rural Setting")]
		Rural_Setting = 7,

		[Display(Name = "Quiet Area")]
		[XmlEnum(Name = "Quiet Area")]
		Quiet_Area = 6,

		[Display(Name = "Pets not Allowed")]
		[XmlEnum(Name = "Pets not Allowed")]
		Pets_not_Allowed = 5,

		[Display(Name = "Mobiles Allowed")]
		[XmlEnum(Name = "Mobiles Allowed")]
		Mobiles_Allowed = 4,

		[Display(Name = "Golf Course Development")]
		[XmlEnum(Name = "Golf Course Development")]
		Golf_Course_Development = 3,

		[Display(Name = "Family Oriented")]
		[XmlEnum(Name = "Family Oriented")]
		Family_Oriented = 2,

		[Display(Name = "Pets Allowed")]
		[XmlEnum(Name = "Pets Allowed")]
		Pets_Allowed = 13,

		[Display(Name = "Age Restrictions")]
		[XmlEnum(Name = "Age Restrictions")]
		Age_Restrictions = 27
    }
}