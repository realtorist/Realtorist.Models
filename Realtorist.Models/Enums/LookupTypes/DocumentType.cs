using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum DocumentType
    {
		[Display(Name = "Floor Plan")]
		[XmlEnum(Name = "Floor Plan")]
		Floor_Plan = 1,

		[Display(Name = "Site Plan")]
		[XmlEnum(Name = "Site Plan")]
		Site_Plan = 2,

		[Display(Name = "Original Blueprints")]
		[XmlEnum(Name = "Original Blueprints")]
		Original_Blueprints = 3,

		[Display(Name = "Water Certificate")]
		[XmlEnum(Name = "Water Certificate")]
		Water_Certificate = 4,

		[Display(Name = "Financial Statements")]
		[XmlEnum(Name = "Financial Statements")]
		Financial_Statements = 5,

		[Display(Name = "Financial Analysis")]
		[XmlEnum(Name = "Financial Analysis")]
		Financial_Analysis = 6,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 7
    }
}