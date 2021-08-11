using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum CurrentUse
    {
		[Display(Name = "Agriculture - active")]
		[XmlEnum(Name = "Agriculture - active")]
		Agriculture___active = 1,

		[Display(Name = "No special use")]
		[XmlEnum(Name = "No special use")]
		No_special_use = 25,

		[Display(Name = "Vineyard")]
		[XmlEnum(Name = "Vineyard")]
		Vineyard = 24,

		[Display(Name = "Recreational")]
		[XmlEnum(Name = "Recreational")]
		Recreational = 23,

		[Display(Name = "Range")]
		[XmlEnum(Name = "Range")]
		Range = 22,

		[Display(Name = "Ranch")]
		[XmlEnum(Name = "Ranch")]
		Ranch = 21,

		[Display(Name = "Quarry")]
		[XmlEnum(Name = "Quarry")]
		Quarry = 20,

		[Display(Name = "Pasture")]
		[XmlEnum(Name = "Pasture")]
		Pasture = 19,

		[Display(Name = "Open pit")]
		[XmlEnum(Name = "Open pit")]
		Open_pit = 18,

		[Display(Name = "Orchard")]
		[XmlEnum(Name = "Orchard")]
		Orchard = 17,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 16,

		[Display(Name = "Mobile home")]
		[XmlEnum(Name = "Mobile home")]
		Mobile_home = 15,

		[Display(Name = "No land")]
		[XmlEnum(Name = "No land")]
		No_land = 26,

		[Display(Name = "Mixed use")]
		[XmlEnum(Name = "Mixed use")]
		Mixed_use = 14,

		[Display(Name = "Hobby Farm")]
		[XmlEnum(Name = "Hobby Farm")]
		Hobby_Farm = 12,

		[Display(Name = "Gravel Yard")]
		[XmlEnum(Name = "Gravel Yard")]
		Gravel_Yard = 11,

		[Display(Name = "Equestrian")]
		[XmlEnum(Name = "Equestrian")]
		Equestrian = 10,

		[Display(Name = "Development other")]
		[XmlEnum(Name = "Development other")]
		Development_other = 9,

		[Display(Name = "Development industrial")]
		[XmlEnum(Name = "Development industrial")]
		Development_industrial = 8,

		[Display(Name = "Development retail")]
		[XmlEnum(Name = "Development retail")]
		Development_retail = 7,

		[Display(Name = "Development residential")]
		[XmlEnum(Name = "Development residential")]
		Development_residential = 6,

		[Display(Name = "Development office")]
		[XmlEnum(Name = "Development office")]
		Development_office = 5,

		[Display(Name = "Development commercial")]
		[XmlEnum(Name = "Development commercial")]
		Development_commercial = 4,

		[Display(Name = "Country residential")]
		[XmlEnum(Name = "Country residential")]
		Country_residential = 3,

		[Display(Name = "Agriculture - inactive")]
		[XmlEnum(Name = "Agriculture - inactive")]
		Agriculture___inactive = 2,

		[Display(Name = "Industrial")]
		[XmlEnum(Name = "Industrial")]
		Industrial = 13,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 27
    }
}