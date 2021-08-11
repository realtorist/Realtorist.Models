using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum ViewType
    {
		[Display(Name = "City view")]
		[XmlEnum(Name = "City view")]
		City_view = 1,

		[Display(Name = "Waterfront - South West")]
		[XmlEnum(Name = "Waterfront - South West")]
		Waterfront___South_West = 20,

		[Display(Name = "Waterfront - South East")]
		[XmlEnum(Name = "Waterfront - South East")]
		Waterfront___South_East = 19,

		[Display(Name = "Waterfront - South")]
		[XmlEnum(Name = "Waterfront - South")]
		Waterfront___South = 18,

		[Display(Name = "Waterfront - North West")]
		[XmlEnum(Name = "Waterfront - North West")]
		Waterfront___North_West = 17,

		[Display(Name = "Waterfront - North East")]
		[XmlEnum(Name = "Waterfront - North East")]
		Waterfront___North_East = 16,

		[Display(Name = "Waterfront - North")]
		[XmlEnum(Name = "Waterfront - North")]
		Waterfront___North = 15,

		[Display(Name = "Waterfront - East")]
		[XmlEnum(Name = "Waterfront - East")]
		Waterfront___East = 14,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 13,

		[Display(Name = "Waterfront - West")]
		[XmlEnum(Name = "Waterfront - West")]
		Waterfront___West = 21,

		[Display(Name = "View (panoramic)")]
		[XmlEnum(Name = "View (panoramic)")]
		View_panoramic = 12,

		[Display(Name = "Ravine view")]
		[XmlEnum(Name = "Ravine view")]
		Ravine_view = 9,

		[Display(Name = "View of water")]
		[XmlEnum(Name = "View of water")]
		View_of_water = 8,

		[Display(Name = "Valley view")]
		[XmlEnum(Name = "Valley view")]
		Valley_view = 7,

		[Display(Name = "View")]
		[XmlEnum(Name = "View")]
		View = 6,

		[Display(Name = "River view")]
		[XmlEnum(Name = "River view")]
		River_view = 5,

		[Display(Name = "Ocean view")]
		[XmlEnum(Name = "Ocean view")]
		Ocean_view = 4,

		[Display(Name = "Mountain view")]
		[XmlEnum(Name = "Mountain view")]
		Mountain_view = 3,

		[Display(Name = "Lake view")]
		[XmlEnum(Name = "Lake view")]
		Lake_view = 2,

		[Display(Name = "Property with view")]
		[XmlEnum(Name = "Property with view")]
		Property_with_view = 10,

		[Display(Name = "Harbour")]
		[XmlEnum(Name = "Harbour")]
		Harbour = 22
    }
}