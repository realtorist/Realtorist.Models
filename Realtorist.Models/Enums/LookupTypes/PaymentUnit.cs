using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum PaymentUnit
    {
		[Display(Name = "Bi-monthly")]
		[XmlEnum(Name = "Bi-monthly")]
		Bi_monthly = 5,

		[Display(Name = "Bi-weekly")]
		[XmlEnum(Name = "Bi-weekly")]
		Bi_weekly = 3,

		[Display(Name = "Daily")]
		[XmlEnum(Name = "Daily")]
		Daily = 1,

		[Display(Name = "Fixed")]
		[XmlEnum(Name = "Fixed")]
		Fixed = 8,

		[Display(Name = "Monthly")]
		[XmlEnum(Name = "Monthly")]
		Monthly = 4,

		[Display(Name = "Quarterly")]
		[XmlEnum(Name = "Quarterly")]
		Quarterly = 6,

		[Display(Name = "Seasonal")]
		[XmlEnum(Name = "Seasonal")]
		Seasonal = 10,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 9,

		[Display(Name = "Weekly")]
		[XmlEnum(Name = "Weekly")]
		Weekly = 2,

		[Display(Name = "Yearly")]
		[XmlEnum(Name = "Yearly")]
		Yearly = 7
    }
}