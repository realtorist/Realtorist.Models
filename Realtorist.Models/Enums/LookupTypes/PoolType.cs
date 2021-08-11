using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum PoolType
    {
		[Display(Name = "Indoor pool")]
		[XmlEnum(Name = "Indoor pool")]
		Indoor_pool = 4,

		[Display(Name = "Pool")]
		[XmlEnum(Name = "Pool")]
		Pool = 1,

		[Display(Name = "Inground pool")]
		[XmlEnum(Name = "Inground pool")]
		Inground_pool = 2,

		[Display(Name = "Outdoor pool")]
		[XmlEnum(Name = "Outdoor pool")]
		Outdoor_pool = 5,

		[Display(Name = "Above ground pool")]
		[XmlEnum(Name = "Above ground pool")]
		Above_ground_pool = 3,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 12,

		[Display(Name = "On Ground Pool")]
		[XmlEnum(Name = "On Ground Pool")]
		On_Ground_Pool = 13
    }
}