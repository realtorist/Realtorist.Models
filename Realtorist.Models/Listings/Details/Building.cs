using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Xml;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Listings.Details
{
    public class Building
    {
        /// <summary>
        /// Number of bathrooms
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Bathrooms")]
        public int? BathroomTotal { get; set; }

        /// <summary>
        /// Number of bedrooms above ground
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Bedrooms")]
        public int? BedroomsAboveGround { get; set; }

        /// <summary>
        /// Number of bedrooms below ground
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Bedrooms")]
        public int? BedroomsBelowGround { get; set; }

        /// <summary>
        /// Number of bedrooms (below + above ground)
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Bedrooms")]
        public int? BedroomsTotal { get; set; }

        /// <summary>
        /// The age of the building
        /// </summary>
        [MaybeNull]
        public string Age { get; set; }

        /// <summary>
        /// The building amenities
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public Amenities[] Amenities { get; set; }

        /// <summary>
        /// The appliances included with the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public Appliances[] Appliances { get; set; }

        /// <summary>
        /// Architectural style of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Exterior features")]
        public ArchitecturalStyle[] ArchitecturalStyle { get; set; }

        /// <summary>
        /// Development of the basement
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public BasementDevelopment[] BasementDevelopment { get; set; }

        /// <summary>
        /// Features of the basement
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public BasementFeatures[] BasementFeatures { get; set; }

        /// <summary>
        /// The type of basement
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public BasementType[] BasementType { get; set; }

        /// <summary>
        /// Ceiling height of the building
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public Measurement CeilingHeight { get; set; }

        /// <summary>
        /// The year the building was built
        /// </summary>
        [DisplayableProperty]
        [SummaryProperty(5)]
        [Display(Name = "Built in")]
        public int? ConstructedDate { get; set; }

        /// <summary>
        /// List of construction materials used in the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Construction")]
        public ConstructionMaterial[] ConstructionMaterial { get; set; }

        /// <summary>
        /// The status of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Construction")]
        public ConstructionStatus? ConstructionStatus { get; set; }

        /// <summary>
        /// The attachment style of the building
        /// </summary>
        [Display(GroupName = "Construction")]
        public ConstructionStyleAttachment? ConstructionStyleAttachment { get; set; }

        /// <summary>
        /// Construction style other
        /// </summary>
        [Display(GroupName = "Construction")]
        public ConstructionStyleOther? ConstructionStyleOther { get; set; }

        /// <summary>
        /// Construction style split level
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Split level", GroupName = "Construction")]
        public ConstructionStyleSplitLevel? ConstructionStyleSplitLevel { get; set; }

        /// <summary>
        /// Type of Cooling in the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public CoolingType[] CoolingType { get; set; }

        /// <summary>
        /// The exterior finish of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Exterior features")]
        public ExteriorFinish[] ExteriorFinish { get; set; }

        /// <summary>
        /// Fire protection and security features of building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public FireProtection[] FireProtection { get; set; }

        /// <summary>
        /// List of fireplace fuels for the fireplaces in building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public FireplaceFuel[] FireplaceFuel { get; set; }

        /// <summary>
        /// Indicates whether there is a fireplace in building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public bool FireplacePresent { get; set; }

        /// <summary>
        /// Total number of fireplaces present in building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public int? FireplaceTotal { get; set; }

        /// <summary>
        /// The types of fireplace in the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public FireplaceType[] FireplaceType { get; set; }

        /// <summary>
        /// Building fixture
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public Fixture[] Fixture { get; set; }

        /// <summary>
        /// The type of flooring in the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public FlooringType[] FlooringType { get; set; }

        /// <summary>
        /// The type of foundation of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Interior features")]
        public FoundationType[] FoundationType { get; set; }

        /// <summary>
        /// The number of half Bathrooms
        /// </summary>
        [DisplayableProperty]
        [Display(Name = "Half bathrooms", GroupName = "Bathrooms")]
        public int? HalfBathTotal { get; set; }

        /// <summary>
        /// Fuel used for heating the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public HeatingFuel[] HeatingFuel { get; set; }

        /// <summary>
        /// The heating type of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Heating & Cooling")]
        public HeatingType[] HeatingType { get; set; }

        /// <summary>
        /// The date the building was renovated
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public string RenovatedDate { get; set; }

        /// <summary>
        /// The type of roofing material of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Exterior features")]
        public RoofMaterial[] RoofMaterial { get; set; }

        /// <summary>
        /// The roof style of the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Exterior features")]
        public RoofStyle[] RoofStyle { get; set; }

        /// <summary>
        /// Details of a single room
        /// </summary>
        [TableView]
        public Room[] Rooms { get; set; }

        /// <summary>
        /// The number of stories of the building
        /// </summary>
        [DisplayableProperty]
        [SummaryProperty(3)]
        [Display(Name = "Storeys")]
        public double? StoriesTotal { get; set; }

        /// <summary>
        /// Building interior size
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Exterior size", GroupName = "Building features")]
        public Measurement SizeExterior { get; set; }

        /// <summary>
        /// Building exterior size
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Interior size", GroupName = "Building features")]
        public Measurement SizeInterior { get; set; }

        /// <summary>
        /// The size of finished interior
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        [Display(Name = "Finished interior size", GroupName = "Building features")]
        public Measurement SizeInteriorFinished { get; set; }

        /// <summary>
        /// Total finished area
        /// </summary>
        [MaybeNull]
        public Measurement TotalFinishedArea { get; set; }

        /// <summary>
        /// Type of Building
        /// </summary>
        [DisplayableProperty]
        [SummaryProperty(2)]
        [Display(Name = "Building Type")]
        public BuildingType[] Type { get; set; }

        /// <summary>
        /// Type of unit
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        public string UnitType { get; set; }

        /// <summary>
        /// The types of power in the building
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Utility")]
        public UtilityPower[] UtilityPower { get; set; }

        /// <summary>
        /// Building water type
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Utility")]
        public UtilityWater[] UtilityWater { get; set; }

        /// <summary>
        /// The type of pool on the property
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public PoolType[] PoolType { get; set; }

        /// <summary>
        /// The features of the pool
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public PoolFeatures[] PoolFeatures { get; set; }

        /// <summary>
        /// Storage Type Included
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public StorageType[] StorageType { get; set; }

        /// <summary>
        /// Total number of buildings included in the property
        /// </summary>
        [DisplayableProperty]
        [Display(GroupName = "Building features")]
        public int? TotalBuildings { get; set; }
        
        /// <summary>
        /// Utilities available
        /// </summary>
        [TableView]
        public Utility[] Utilities { get; set; }

        /// <summary>
        /// Types of views available
        /// </summary>
        [Display(Name = "View", GroupName = "Building features")]
        public ViewType[] ViewType { get; set; }
    }
}