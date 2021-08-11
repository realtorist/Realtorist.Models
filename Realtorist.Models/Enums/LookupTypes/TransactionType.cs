using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum TransactionType
    {
		[Display(Name = "For sale")]
		[XmlEnum(Name = "For sale")]
		For_sale = 2,

		[Display(Name = "For rent")]
		[XmlEnum(Name = "For rent")]
		For_rent = 3,

		[Display(Name = "For lease")]
		[XmlEnum(Name = "For lease")]
		For_lease = 4,

		[Display(Name = "For sale or rent")]
		[XmlEnum(Name = "For sale or rent")]
		For_sale_or_rent = 1
    }
}