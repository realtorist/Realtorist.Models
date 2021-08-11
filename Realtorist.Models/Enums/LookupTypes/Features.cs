using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum Features
    {
		[Display(Name = "Acreage")]
		[XmlEnum(Name = "Acreage")]
		Acreage = 1,

		[Display(Name = "Pylon  sign")]
		[XmlEnum(Name = "Pylon  sign")]
		Pylon__sign = 482,

		[Display(Name = "Rail")]
		[XmlEnum(Name = "Rail")]
		Rail = 484,

		[Display(Name = "Rear loading")]
		[XmlEnum(Name = "Rear loading")]
		Rear_loading = 485,

		[Display(Name = "Signs allowed")]
		[XmlEnum(Name = "Signs allowed")]
		Signs_allowed = 496,

		[Display(Name = "Signs provided")]
		[XmlEnum(Name = "Signs provided")]
		Signs_provided = 497,

		[Display(Name = "Slatted floors")]
		[XmlEnum(Name = "Slatted floors")]
		Slatted_floors = 499,

		[Display(Name = "Tenant improvement")]
		[XmlEnum(Name = "Tenant improvement")]
		Tenant_improvement = 514,

		[Display(Name = "Yard drainage")]
		[XmlEnum(Name = "Yard drainage")]
		Yard_drainage = 524,

		[Display(Name = "Flat")]
		[XmlEnum(Name = "Flat")]
		Flat = 525,

		[Display(Name = "Tile Drained")]
		[XmlEnum(Name = "Tile Drained")]
		Tile_Drained = 526,

		[Display(Name = "Hilly")]
		[XmlEnum(Name = "Hilly")]
		Hilly = 529,

		[Display(Name = "Year Round Living")]
		[XmlEnum(Name = "Year Round Living")]
		Year_Round_Living = 536,

		[Display(Name = "Carpet Free")]
		[XmlEnum(Name = "Carpet Free")]
		Carpet_Free = 537,

		[Display(Name = "Private Elevator")]
		[XmlEnum(Name = "Private Elevator")]
		Private_Elevator = 538,

		[Display(Name = "Glass Elevator")]
		[XmlEnum(Name = "Glass Elevator")]
		Glass_Elevator = 539,

		[Display(Name = "Granite Countertops")]
		[XmlEnum(Name = "Granite Countertops")]
		Granite_Countertops = 562,

		[Display(Name = "Wood Countertops")]
		[XmlEnum(Name = "Wood Countertops")]
		Wood_Countertops = 563,

		[Display(Name = "Laminate Countertops")]
		[XmlEnum(Name = "Laminate Countertops")]
		Laminate_Countertops = 564,

		[Display(Name = "Corion Countertops")]
		[XmlEnum(Name = "Corion Countertops")]
		Corion_Countertops = 565,

		[Display(Name = "Slate Countertops")]
		[XmlEnum(Name = "Slate Countertops")]
		Slate_Countertops = 566,

		[Display(Name = "Metallic Countertops")]
		[XmlEnum(Name = "Metallic Countertops")]
		Metallic_Countertops = 567,

		[Display(Name = "Shoreline Owned")]
		[XmlEnum(Name = "Shoreline Owned")]
		Shoreline_Owned = 571,

		[Display(Name = "Mixed Bush")]
		[XmlEnum(Name = "Mixed Bush")]
		Mixed_Bush = 572,

		[Display(Name = "No Driveway")]
		[XmlEnum(Name = "No Driveway")]
		No_Driveway = 593,

		[Display(Name = "Non Paved Driveway")]
		[XmlEnum(Name = "Non Paved Driveway")]
		Non_Paved_Driveway = 625,

		[Display(Name = "Pole sign")]
		[XmlEnum(Name = "Pole sign")]
		Pole_sign = 478,

		[Display(Name = "Shared Driveway")]
		[XmlEnum(Name = "Shared Driveway")]
		Shared_Driveway = 627,

		[Display(Name = "Paved yard")]
		[XmlEnum(Name = "Paved yard")]
		Paved_yard = 474,

		[Display(Name = "Partially serviced")]
		[XmlEnum(Name = "Partially serviced")]
		Partially_serviced = 472,

		[Display(Name = "Environmental reserve")]
		[XmlEnum(Name = "Environmental reserve")]
		Environmental_reserve = 408,

		[Display(Name = "Gently Rolling")]
		[XmlEnum(Name = "Gently Rolling")]
		Gently_Rolling = 429,

		[Display(Name = "Gravel lane")]
		[XmlEnum(Name = "Gravel lane")]
		Gravel_lane = 431,

		[Display(Name = "Handicapped provisions")]
		[XmlEnum(Name = "Handicapped provisions")]
		Handicapped_provisions = 432,

		[Display(Name = "Heavy bush")]
		[XmlEnum(Name = "Heavy bush")]
		Heavy_bush = 434,

		[Display(Name = "Industrial condominium")]
		[XmlEnum(Name = "Industrial condominium")]
		Industrial_condominium = 437,

		[Display(Name = "Industrial mall/subdivision")]
		[XmlEnum(Name = "Industrial mall/subdivision")]
		Industrial_mall_subdivision = 438,

		[Display(Name = "Inside load")]
		[XmlEnum(Name = "Inside load")]
		Inside_load = 439,

		[Display(Name = "Leasehold improvements")]
		[XmlEnum(Name = "Leasehold improvements")]
		Leasehold_improvements = 442,

		[Display(Name = "Level")]
		[XmlEnum(Name = "Level")]
		Level = 443,

		[Display(Name = "Loading dock seals")]
		[XmlEnum(Name = "Loading dock seals")]
		Loading_dock_seals = 445,

		[Display(Name = "Marine Oriented")]
		[XmlEnum(Name = "Marine Oriented")]
		Marine_Oriented = 448,

		[Display(Name = "Marketing quotas")]
		[XmlEnum(Name = "Marketing quotas")]
		Marketing_quotas = 449,

		[Display(Name = "Marsh")]
		[XmlEnum(Name = "Marsh")]
		Marsh = 450,

		[Display(Name = "Medium bush")]
		[XmlEnum(Name = "Medium bush")]
		Medium_bush = 452,

		[Display(Name = "Medium Rolling")]
		[XmlEnum(Name = "Medium Rolling")]
		Medium_Rolling = 453,

		[Display(Name = "Moorage")]
		[XmlEnum(Name = "Moorage")]
		Moorage = 457,

		[Display(Name = "Mountain")]
		[XmlEnum(Name = "Mountain")]
		Mountain = 458,

		[Display(Name = "Natural light")]
		[XmlEnum(Name = "Natural light")]
		Natural_light = 459,

		[Display(Name = "No bush")]
		[XmlEnum(Name = "No bush")]
		No_bush = 460,

		[Display(Name = "No services")]
		[XmlEnum(Name = "No services")]
		No_services = 462,

		[Display(Name = "Office space")]
		[XmlEnum(Name = "Office space")]
		Office_space = 465,

		[Display(Name = "Oil/grease interceptors")]
		[XmlEnum(Name = "Oil/grease interceptors")]
		Oil_grease_interceptors = 466,

		[Display(Name = "On rail trackage")]
		[XmlEnum(Name = "On rail trackage")]
		On_rail_trackage = 467,

		[Display(Name = "Overhead doors")]
		[XmlEnum(Name = "Overhead doors")]
		Overhead_doors = 469,

		[Display(Name = "Passenger elevator")]
		[XmlEnum(Name = "Passenger elevator")]
		Passenger_elevator = 473,

		[Display(Name = "Heavy loading")]
		[XmlEnum(Name = "Heavy loading")]
		Heavy_loading = 631,

		[Display(Name = "Gated community")]
		[XmlEnum(Name = "Gated community")]
		Gated_community = 632,

		[Display(Name = "Country residential")]
		[XmlEnum(Name = "Country residential")]
		Country_residential = 633,

		[Display(Name = "Mutual Driveway")]
		[XmlEnum(Name = "Mutual Driveway")]
		Mutual_Driveway = 665,

		[Display(Name = "One Balcony")]
		[XmlEnum(Name = "One Balcony")]
		One_Balcony = 666,

		[Display(Name = "Private Yard")]
		[XmlEnum(Name = "Private Yard")]
		Private_Yard = 668,

		[Display(Name = "Random Tiled")]
		[XmlEnum(Name = "Random Tiled")]
		Random_Tiled = 669,

		[Display(Name = "Rear Driveway")]
		[XmlEnum(Name = "Rear Driveway")]
		Rear_Driveway = 670,

		[Display(Name = "Sandy Beach")]
		[XmlEnum(Name = "Sandy Beach")]
		Sandy_Beach = 671,

		[Display(Name = "Sauna")]
		[XmlEnum(Name = "Sauna")]
		Sauna = 672,

		[Display(Name = "Side Driveway")]
		[XmlEnum(Name = "Side Driveway")]
		Side_Driveway = 673,

		[Display(Name = "Single Driveway")]
		[XmlEnum(Name = "Single Driveway")]
		Single_Driveway = 674,

		[Display(Name = "Three Balconies")]
		[XmlEnum(Name = "Three Balconies")]
		Three_Balconies = 675,

		[Display(Name = "Treed Lot")]
		[XmlEnum(Name = "Treed Lot")]
		Treed_Lot = 676,

		[Display(Name = "Two Balconies")]
		[XmlEnum(Name = "Two Balconies")]
		Two_Balconies = 677,

		[Display(Name = "Walk-In Closet")]
		[XmlEnum(Name = "Walk-In Closet")]
		Walk_In_Closet = 678,

		[Display(Name = "Greenspace")]
		[XmlEnum(Name = "Greenspace")]
		Greenspace = 679,

		[Display(Name = "Gas BBQ Hookup")]
		[XmlEnum(Name = "Gas BBQ Hookup")]
		Gas_BBQ_Hookup = 680,

		[Display(Name = "Single Family")]
		[XmlEnum(Name = "Single Family")]
		Single_Family = 681,

		[Display(Name = "Agriculture")]
		[XmlEnum(Name = "Agriculture")]
		Agriculture = 682,

		[Display(Name = "Vacant Land")]
		[XmlEnum(Name = "Vacant Land")]
		Vacant_Land = 683,

		[Display(Name = "Office")]
		[XmlEnum(Name = "Office")]
		Office = 684,

		[Display(Name = "Retail")]
		[XmlEnum(Name = "Retail")]
		Retail = 685,

		[Display(Name = "Business")]
		[XmlEnum(Name = "Business")]
		Business = 686,

		[Display(Name = "Industrial")]
		[XmlEnum(Name = "Industrial")]
		Industrial = 687,

		[Display(Name = "Parking")]
		[XmlEnum(Name = "Parking")]
		Parking = 688,

		[Display(Name = "Institutional - Special Purpose")]
		[XmlEnum(Name = "Institutional - Special Purpose")]
		Institutional___Special_Purpose = 689,

		[Display(Name = "Multi-family")]
		[XmlEnum(Name = "Multi-family")]
		Multi_family = 690,

		[Display(Name = "Interlocking Driveway")]
		[XmlEnum(Name = "Interlocking Driveway")]
		Interlocking_Driveway = 664,

		[Display(Name = "In-Law Suite")]
		[XmlEnum(Name = "In-Law Suite")]
		In_Law_Suite = 663,

		[Display(Name = "Gravel Driveway")]
		[XmlEnum(Name = "Gravel Driveway")]
		Gravel_Driveway = 662,

		[Display(Name = "Grade Entrance")]
		[XmlEnum(Name = "Grade Entrance")]
		Grade_Entrance = 661,

		[Display(Name = "Within city limits")]
		[XmlEnum(Name = "Within city limits")]
		Within_city_limits = 634,

		[Display(Name = "Recreational")]
		[XmlEnum(Name = "Recreational")]
		Recreational = 635,

		[Display(Name = "In suite Laundry")]
		[XmlEnum(Name = "In suite Laundry")]
		In_suite_Laundry = 636,

		[Display(Name = "Gazebo")]
		[XmlEnum(Name = "Gazebo")]
		Gazebo = 637,

		[Display(Name = "Assisted Living")]
		[XmlEnum(Name = "Assisted Living")]
		Assisted_Living = 638,

		[Display(Name = "Guest Suite")]
		[XmlEnum(Name = "Guest Suite")]
		Guest_Suite = 639,

		[Display(Name = "Laundry- Coin operated")]
		[XmlEnum(Name = "Laundry- Coin operated")]
		Laundry__Coin_operated = 640,

		[Display(Name = "Picnic Area")]
		[XmlEnum(Name = "Picnic Area")]
		Picnic_Area = 641,

		[Display(Name = "air climatisГ© mural")]
		[XmlEnum(Name = "air climatisГ© mural")]
		air_climatis_mural = 642,

		[Display(Name = "Central Exhaust")]
		[XmlEnum(Name = "Central Exhaust")]
		Central_Exhaust = 644,

		[Display(Name = "Landing Strip")]
		[XmlEnum(Name = "Landing Strip")]
		Landing_Strip = 645,

		[Display(Name = "No Pet Home")]
		[XmlEnum(Name = "No Pet Home")]
		No_Pet_Home = 646,

		[Display(Name = "Dry")]
		[XmlEnum(Name = "Dry")]
		Dry = 405,

		[Display(Name = "Sump Pump")]
		[XmlEnum(Name = "Sump Pump")]
		Sump_Pump = 647,

		[Display(Name = "Balcony enclosed")]
		[XmlEnum(Name = "Balcony enclosed")]
		Balcony_enclosed = 649,

		[Display(Name = "Energy Efficient")]
		[XmlEnum(Name = "Energy Efficient")]
		Energy_Efficient = 650,

		[Display(Name = "Automatic Garage Door Opener")]
		[XmlEnum(Name = "Automatic Garage Door Opener")]
		Automatic_Garage_Door_Opener = 651,

		[Display(Name = "Solar Equipment")]
		[XmlEnum(Name = "Solar Equipment")]
		Solar_Equipment = 652,

		[Display(Name = "Balcony/Deck/Patio")]
		[XmlEnum(Name = "Balcony/Deck/Patio")]
		Balcony_Deck_Patio = 653,

		[Display(Name = "2nd Kitchen")]
		[XmlEnum(Name = "2nd Kitchen")]
		_2nd_Kitchen = 654,

		[Display(Name = "Atrium/Sunroom")]
		[XmlEnum(Name = "Atrium/Sunroom")]
		Atrium_Sunroom = 655,

		[Display(Name = "Circular Driveway")]
		[XmlEnum(Name = "Circular Driveway")]
		Circular_Driveway = 656,

		[Display(Name = "Concrete Driveway")]
		[XmlEnum(Name = "Concrete Driveway")]
		Concrete_Driveway = 657,

		[Display(Name = "Covered Porch")]
		[XmlEnum(Name = "Covered Porch")]
		Covered_Porch = 658,

		[Display(Name = "Finished Driveway")]
		[XmlEnum(Name = "Finished Driveway")]
		Finished_Driveway = 659,

		[Display(Name = "Front Driveway")]
		[XmlEnum(Name = "Front Driveway")]
		Front_Driveway = 660,

		[Display(Name = "Structural wood basement floor")]
		[XmlEnum(Name = "Structural wood basement floor")]
		Structural_wood_basement_floor = 648,

		[Display(Name = "Dock levelers")]
		[XmlEnum(Name = "Dock levelers")]
		Dock_levelers = 403,

		[Display(Name = "Divisible")]
		[XmlEnum(Name = "Divisible")]
		Divisible = 402,

		[Display(Name = "Crown leases available")]
		[XmlEnum(Name = "Crown leases available")]
		Crown_leases_available = 401,

		[Display(Name = "Farm setting")]
		[XmlEnum(Name = "Farm setting")]
		Farm_setting = 87,

		[Display(Name = "Handicapped adaptable")]
		[XmlEnum(Name = "Handicapped adaptable")]
		Handicapped_adaptable = 88,

		[Display(Name = "Flat site")]
		[XmlEnum(Name = "Flat site")]
		Flat_site = 90,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 94,

		[Display(Name = "Back lane")]
		[XmlEnum(Name = "Back lane")]
		Back_lane = 106,

		[Display(Name = "Handicap access")]
		[XmlEnum(Name = "Handicap access")]
		Handicap_access = 107,

		[Display(Name = "Paved lane")]
		[XmlEnum(Name = "Paved lane")]
		Paved_lane = 108,

		[Display(Name = "No back lane")]
		[XmlEnum(Name = "No back lane")]
		No_back_lane = 111,

		[Display(Name = "Park/reserve")]
		[XmlEnum(Name = "Park/reserve")]
		Park_reserve = 112,

		[Display(Name = "Subdividable lot")]
		[XmlEnum(Name = "Subdividable lot")]
		Subdividable_lot = 114,

		[Display(Name = "Hardwood bush")]
		[XmlEnum(Name = "Hardwood bush")]
		Hardwood_bush = 115,

		[Display(Name = "Softwood bush")]
		[XmlEnum(Name = "Softwood bush")]
		Softwood_bush = 116,

		[Display(Name = "Conservation/green belt")]
		[XmlEnum(Name = "Conservation/green belt")]
		Conservation_green_belt = 118,

		[Display(Name = "Golf course/parkland")]
		[XmlEnum(Name = "Golf course/parkland")]
		Golf_course_parkland = 119,

		[Display(Name = "Hazardous land")]
		[XmlEnum(Name = "Hazardous land")]
		Hazardous_land = 121,

		[Display(Name = "Wetlands")]
		[XmlEnum(Name = "Wetlands")]
		Wetlands = 122,

		[Display(Name = "Lane")]
		[XmlEnum(Name = "Lane")]
		Lane = 125,

		[Display(Name = "Rectangular")]
		[XmlEnum(Name = "Rectangular")]
		Rectangular = 126,

		[Display(Name = "Pie")]
		[XmlEnum(Name = "Pie")]
		Pie = 131,

		[Display(Name = "Wedge")]
		[XmlEnum(Name = "Wedge")]
		Wedge = 132,

		[Display(Name = "Wet bar")]
		[XmlEnum(Name = "Wet bar")]
		Wet_bar = 141,

		[Display(Name = "Storm & screens")]
		[XmlEnum(Name = "Storm & screens")]
		Storm__screens = 150,

		[Display(Name = "Elevator")]
		[XmlEnum(Name = "Elevator")]
		Elevator = 161,

		[Display(Name = "Bicycle parking")]
		[XmlEnum(Name = "Bicycle parking")]
		Bicycle_parking = 184,

		[Display(Name = "Potential recreational")]
		[XmlEnum(Name = "Potential recreational")]
		Potential_recreational = 197,

		[Display(Name = "Resort")]
		[XmlEnum(Name = "Resort")]
		Resort = 85,

		[Display(Name = "Bush")]
		[XmlEnum(Name = "Bush")]
		Bush = 84,

		[Display(Name = "Open space")]
		[XmlEnum(Name = "Open space")]
		Open_space = 82,

		[Display(Name = "Waterway")]
		[XmlEnum(Name = "Waterway")]
		Waterway = 81,

		[Display(Name = "Beach property")]
		[XmlEnum(Name = "Beach property")]
		Beach_property = 3,

		[Display(Name = "Central location")]
		[XmlEnum(Name = "Central location")]
		Central_location = 5,

		[Display(Name = "Cul-de-sac")]
		[XmlEnum(Name = "Cul-de-sac")]
		Cul_de_sac = 7,

		[Display(Name = "Curb & gutter")]
		[XmlEnum(Name = "Curb & gutter")]
		Curb__gutter = 8,

		[Display(Name = "Hillside")]
		[XmlEnum(Name = "Hillside")]
		Hillside = 15,

		[Display(Name = "Level lot")]
		[XmlEnum(Name = "Level lot")]
		Level_lot = 20,

		[Display(Name = "Low maintenance yard")]
		[XmlEnum(Name = "Low maintenance yard")]
		Low_maintenance_yard = 21,

		[Display(Name = "Park setting")]
		[XmlEnum(Name = "Park setting")]
		Park_setting = 27,

		[Display(Name = "Private setting")]
		[XmlEnum(Name = "Private setting")]
		Private_setting = 30,

		[Display(Name = "Southern exposure")]
		[XmlEnum(Name = "Southern exposure")]
		Southern_exposure = 40,

		[Display(Name = "Treed")]
		[XmlEnum(Name = "Treed")]
		Treed = 42,

		[Display(Name = "Underground services")]
		[XmlEnum(Name = "Underground services")]
		Underground_services = 43,

		[Display(Name = "Will consider trade")]
		[XmlEnum(Name = "Will consider trade")]
		Will_consider_trade = 200,

		[Display(Name = "Wooded area")]
		[XmlEnum(Name = "Wooded area")]
		Wooded_area = 50,

		[Display(Name = "Irregular lot size")]
		[XmlEnum(Name = "Irregular lot size")]
		Irregular_lot_size = 54,

		[Display(Name = "Rocky")]
		[XmlEnum(Name = "Rocky")]
		Rocky = 55,

		[Display(Name = "Sloping")]
		[XmlEnum(Name = "Sloping")]
		Sloping = 57,

		[Display(Name = "See remarks")]
		[XmlEnum(Name = "See remarks")]
		See_remarks = 61,

		[Display(Name = "Rail trackage")]
		[XmlEnum(Name = "Rail trackage")]
		Rail_trackage = 65,

		[Display(Name = "Visual exposure")]
		[XmlEnum(Name = "Visual exposure")]
		Visual_exposure = 66,

		[Display(Name = "Ravine")]
		[XmlEnum(Name = "Ravine")]
		Ravine = 67,

		[Display(Name = "Hobby farm")]
		[XmlEnum(Name = "Hobby farm")]
		Hobby_farm = 71,

		[Display(Name = "Rolling")]
		[XmlEnum(Name = "Rolling")]
		Rolling = 74,

		[Display(Name = "Partially cleared")]
		[XmlEnum(Name = "Partially cleared")]
		Partially_cleared = 76,

		[Display(Name = "Backs on greenbelt")]
		[XmlEnum(Name = "Backs on greenbelt")]
		Backs_on_greenbelt = 79,

		[Display(Name = "Tiled")]
		[XmlEnum(Name = "Tiled")]
		Tiled = 80,

		[Display(Name = "Corner Site")]
		[XmlEnum(Name = "Corner Site")]
		Corner_Site = 52,

		[Display(Name = "Hospitality")]
		[XmlEnum(Name = "Hospitality")]
		Hospitality = 691,

		[Display(Name = "Beach")]
		[XmlEnum(Name = "Beach")]
		Beach = 211,

		[Display(Name = "Crane")]
		[XmlEnum(Name = "Crane")]
		Crane = 217,

		[Display(Name = "Lot with lake")]
		[XmlEnum(Name = "Lot with lake")]
		Lot_with_lake = 311,

		[Display(Name = "Bathroom Adjoining Primary Bedroom")]
		[XmlEnum(Name = "Bathroom Adjoining Primary Bedroom")]
		Bathroom_Adjoining_Primary_Bedroom = 318,

		[Display(Name = "Podium bath")]
		[XmlEnum(Name = "Podium bath")]
		Podium_bath = 319,

		[Display(Name = "Separate shower")]
		[XmlEnum(Name = "Separate shower")]
		Separate_shower = 320,

		[Display(Name = "Jacuzzi bath-tub")]
		[XmlEnum(Name = "Jacuzzi bath-tub")]
		Jacuzzi_bath_tub = 321,

		[Display(Name = "Dry well")]
		[XmlEnum(Name = "Dry well")]
		Dry_well = 348,

		[Display(Name = "Sliding windows")]
		[XmlEnum(Name = "Sliding windows")]
		Sliding_windows = 351,

		[Display(Name = "Hung windows (Guillotine)")]
		[XmlEnum(Name = "Hung windows (Guillotine)")]
		Hung_windows_Guillotine = 352,

		[Display(Name = "Crank windows")]
		[XmlEnum(Name = "Crank windows")]
		Crank_windows = 353,

		[Display(Name = "French window")]
		[XmlEnum(Name = "French window")]
		French_window = 354,

		[Display(Name = "French door")]
		[XmlEnum(Name = "French door")]
		French_door = 355,

		[Display(Name = "Broadloom Upgraded")]
		[XmlEnum(Name = "Broadloom Upgraded")]
		Broadloom_Upgraded = 360,

		[Display(Name = "Closet Organizers")]
		[XmlEnum(Name = "Closet Organizers")]
		Closet_Organizers = 361,

		[Display(Name = "Dance Floor")]
		[XmlEnum(Name = "Dance Floor")]
		Dance_Floor = 362,

		[Display(Name = "Exterior Walls- 2x6\"")]
		[XmlEnum(Name = "Exterior Walls- 2x6\"")]
		Exterior_Walls__2x6 = 364,

		[Display(Name = "No Animal Home")]
		[XmlEnum(Name = "No Animal Home")]
		No_Animal_Home = 367,

		[Display(Name = "No Smoking Home")]
		[XmlEnum(Name = "No Smoking Home")]
		No_Smoking_Home = 368,

		[Display(Name = "Drapery Rods")]
		[XmlEnum(Name = "Drapery Rods")]
		Drapery_Rods = 370,

		[Display(Name = "Silent Floor Joists")]
		[XmlEnum(Name = "Silent Floor Joists")]
		Silent_Floor_Joists = 371,

		[Display(Name = "Skylight")]
		[XmlEnum(Name = "Skylight")]
		Skylight = 372,

		[Display(Name = "Swirlpool bath (Jacuzzi)")]
		[XmlEnum(Name = "Swirlpool bath (Jacuzzi)")]
		Swirlpool_bath_Jacuzzi = 376,

		[Display(Name = "Built-in wall unit")]
		[XmlEnum(Name = "Built-in wall unit")]
		Built_in_wall_unit = 377,

		[Display(Name = "Air lines")]
		[XmlEnum(Name = "Air lines")]
		Air_lines = 380,

		[Display(Name = "Bathroom with separate shower")]
		[XmlEnum(Name = "Bathroom with separate shower")]
		Bathroom_with_separate_shower = 384,

		[Display(Name = "Crops")]
		[XmlEnum(Name = "Crops")]
		Crops = 399,

		[Display(Name = "No neighbours behind")]
		[XmlEnum(Name = "No neighbours behind")]
		No_neighbours_behind = 310,

		[Display(Name = "PVC window")]
		[XmlEnum(Name = "PVC window")]
		PVC_window = 289,

		[Display(Name = "Wood windows")]
		[XmlEnum(Name = "Wood windows")]
		Wood_windows = 288,

		[Display(Name = "Aluminium window")]
		[XmlEnum(Name = "Aluminium window")]
		Aluminium_window = 287,

		[Display(Name = "Dock height loading")]
		[XmlEnum(Name = "Dock height loading")]
		Dock_height_loading = 219,

		[Display(Name = "Door 10 to 15 ft.")]
		[XmlEnum(Name = "Door 10 to 15 ft.")]
		Door_10_to_15_ft = 220,

		[Display(Name = "Door under 10 ft.")]
		[XmlEnum(Name = "Door under 10 ft.")]
		Door_under_10_ft = 221,

		[Display(Name = "Doors 15 to 20 ft.")]
		[XmlEnum(Name = "Doors 15 to 20 ft.")]
		Doors_15_to_20_ft = 222,

		[Display(Name = "Freight elevator")]
		[XmlEnum(Name = "Freight elevator")]
		Freight_elevator = 225,

		[Display(Name = "Hoists")]
		[XmlEnum(Name = "Hoists")]
		Hoists = 228,

		[Display(Name = "Central island")]
		[XmlEnum(Name = "Central island")]
		Central_island = 232,

		[Display(Name = "Levelers")]
		[XmlEnum(Name = "Levelers")]
		Levelers = 233,

		[Display(Name = "Lighting")]
		[XmlEnum(Name = "Lighting")]
		Lighting = 234,

		[Display(Name = "None")]
		[XmlEnum(Name = "None")]
		None = 237,

		[Display(Name = "Waterfront loading")]
		[XmlEnum(Name = "Waterfront loading")]
		Waterfront_loading = 250,

		[Display(Name = "Wheelchair access")]
		[XmlEnum(Name = "Wheelchair access")]
		Wheelchair_access = 251,

		[Display(Name = "Conveyor")]
		[XmlEnum(Name = "Conveyor")]
		Conveyor = 216,

		[Display(Name = "Window display")]
		[XmlEnum(Name = "Window display")]
		Window_display = 252,

		[Display(Name = "Double width or more driveway")]
		[XmlEnum(Name = "Double width or more driveway")]
		Double_width_or_more_driveway = 256,

		[Display(Name = "Paved driveway")]
		[XmlEnum(Name = "Paved driveway")]
		Paved_driveway = 257,

		[Display(Name = "Crushed stone driveway")]
		[XmlEnum(Name = "Crushed stone driveway")]
		Crushed_stone_driveway = 258,

		[Display(Name = "Plain paving stone driveway")]
		[XmlEnum(Name = "Plain paving stone driveway")]
		Plain_paving_stone_driveway = 259,

		[Display(Name = "Wood cupboard")]
		[XmlEnum(Name = "Wood cupboard")]
		Wood_cupboard = 261,

		[Display(Name = "Melamine cupboard")]
		[XmlEnum(Name = "Melamine cupboard")]
		Melamine_cupboard = 262,

		[Display(Name = "Laminated cupboard")]
		[XmlEnum(Name = "Laminated cupboard")]
		Laminated_cupboard = 263,

		[Display(Name = "Garbage disposal unit")]
		[XmlEnum(Name = "Garbage disposal unit")]
		Garbage_disposal_unit = 272,

		[Display(Name = "Trash compactor")]
		[XmlEnum(Name = "Trash compactor")]
		Trash_compactor = 273,

		[Display(Name = "Embedded oven")]
		[XmlEnum(Name = "Embedded oven")]
		Embedded_oven = 274,

		[Display(Name = "Central cooking island")]
		[XmlEnum(Name = "Central cooking island")]
		Central_cooking_island = 275,

		[Display(Name = "Cooking surface")]
		[XmlEnum(Name = "Cooking surface")]
		Cooking_surface = 276,

		[Display(Name = "Balcony")]
		[XmlEnum(Name = "Balcony")]
		Balcony = 254,

		[Display(Name = "VisitAble")]
		[XmlEnum(Name = "VisitAble")]
		VisitAble = 692
    }
}