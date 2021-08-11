using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum OwnershipType
    {
		[Display(Name = "Condominium/Strata")]
		[XmlEnum(Name = "Condominium/Strata")]
		Condominium_Strata = 1,

		[Display(Name = "Other, See Remarks")]
		[XmlEnum(Name = "Other, See Remarks")]
		Other_See_Remarks = 15,

		[Display(Name = "Cooperative")]
		[XmlEnum(Name = "Cooperative")]
		Cooperative = 14,

		[Display(Name = "Condominium")]
		[XmlEnum(Name = "Condominium")]
		Condominium = 13,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 8,

		[Display(Name = "Strata")]
		[XmlEnum(Name = "Strata")]
		Strata = 12,

		[Display(Name = "Freehold Condo")]
		[XmlEnum(Name = "Freehold Condo")]
		Freehold_Condo = 11,

		[Display(Name = "Leasehold/Leased Land")]
		[XmlEnum(Name = "Leasehold/Leased Land")]
		Leasehold_Leased_Land = 16,

		[Display(Name = "Life Lease")]
		[XmlEnum(Name = "Life Lease")]
		Life_Lease = 10,

		[Display(Name = "Freehold")]
		[XmlEnum(Name = "Freehold")]
		Freehold = 3,

		[Display(Name = "Leasehold Condo/Strata")]
		[XmlEnum(Name = "Leasehold Condo/Strata")]
		Leasehold_Condo_Strata = 2,

		[Display(Name = "Partial")]
		[XmlEnum(Name = "Partial")]
		Partial = 7,

		[Display(Name = "Shares in Co-operative")]
		[XmlEnum(Name = "Shares in Co-operative")]
		Shares_in_Co_operative = 6,

		[Display(Name = "Timeshare/Fractional")]
		[XmlEnum(Name = "Timeshare/Fractional")]
		Timeshare_Fractional = 5,

		[Display(Name = "Undivided Co-ownership")]
		[XmlEnum(Name = "Undivided Co-ownership")]
		Undivided_Co_ownership = 9,

		[Display(Name = "Leasehold")]
		[XmlEnum(Name = "Leasehold")]
		Leasehold = 4,

		[Display(Name = "Bare Land Condo")]
		[XmlEnum(Name = "Bare Land Condo")]
		Bare_Land_Condo = 17
    }
}