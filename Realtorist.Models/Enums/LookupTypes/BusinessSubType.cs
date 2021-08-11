using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Realtorist.Models.Enums.LookupTypes
{
    public enum BusinessSubType
    {
		[Display(Name = "Bed & Breakfast")]
		[XmlEnum(Name = "Bed & Breakfast")]
		Bed__Breakfast = 9,

		[Display(Name = "Lawn & garden")]
		[XmlEnum(Name = "Lawn & garden")]
		Lawn__garden = 130,

		[Display(Name = "Office machines")]
		[XmlEnum(Name = "Office machines")]
		Office_machines = 134,

		[Display(Name = "Paint & Wallpaper")]
		[XmlEnum(Name = "Paint & Wallpaper")]
		Paint__Wallpaper = 135,

		[Display(Name = "Rent-All")]
		[XmlEnum(Name = "Rent-All")]
		Rent_All = 138,

		[Display(Name = "Stationery")]
		[XmlEnum(Name = "Stationery")]
		Stationery = 143,

		[Display(Name = "Television sales")]
		[XmlEnum(Name = "Television sales")]
		Television_sales = 146,

		[Display(Name = "Variety store")]
		[XmlEnum(Name = "Variety store")]
		Variety_store = 149,

		[Display(Name = "Workshop equipment")]
		[XmlEnum(Name = "Workshop equipment")]
		Workshop_equipment = 150,

		[Display(Name = "Wood shop")]
		[XmlEnum(Name = "Wood shop")]
		Wood_shop = 151,

		[Display(Name = "General sales/services")]
		[XmlEnum(Name = "General sales/services")]
		General_sales_services = 156,

		[Display(Name = "Appliance")]
		[XmlEnum(Name = "Appliance")]
		Appliance = 174,

		[Display(Name = "Audio")]
		[XmlEnum(Name = "Audio")]
		Audio = 175,

		[Display(Name = "Electrical")]
		[XmlEnum(Name = "Electrical")]
		Electrical = 176,

		[Display(Name = "Gifts")]
		[XmlEnum(Name = "Gifts")]
		Gifts = 177,

		[Display(Name = "Television")]
		[XmlEnum(Name = "Television")]
		Television = 178,

		[Display(Name = "Misc retail")]
		[XmlEnum(Name = "Misc retail")]
		Misc_retail = 182,

		[Display(Name = "Automotive/aircraft")]
		[XmlEnum(Name = "Automotive/aircraft")]
		Automotive_aircraft = 183,

		[Display(Name = "Drugs/cosmetics")]
		[XmlEnum(Name = "Drugs/cosmetics")]
		Drugs_cosmetics = 184,

		[Display(Name = "Dry goods/fashion")]
		[XmlEnum(Name = "Dry goods/fashion")]
		Dry_goods_fashion = 185,

		[Display(Name = "Hardware/decorating")]
		[XmlEnum(Name = "Hardware/decorating")]
		Hardware_decorating = 186,

		[Display(Name = "Retail & offices")]
		[XmlEnum(Name = "Retail & offices")]
		Retail__offices = 201,

		[Display(Name = "Retail/residential")]
		[XmlEnum(Name = "Retail/residential")]
		Retail_residential = 202,

		[Display(Name = "Retail/offices/residential")]
		[XmlEnum(Name = "Retail/offices/residential")]
		Retail_offices_residential = 206,

		[Display(Name = "Sales/service")]
		[XmlEnum(Name = "Sales/service")]
		Sales_service = 209,

		[Display(Name = "Retail misc.")]
		[XmlEnum(Name = "Retail misc.")]
		Retail_misc = 213,

		[Display(Name = "Business")]
		[XmlEnum(Name = "Business")]
		Business = 217,

		[Display(Name = "Antiques")]
		[XmlEnum(Name = "Antiques")]
		Antiques = 222,

		[Display(Name = "Arts & Crafts")]
		[XmlEnum(Name = "Arts & Crafts")]
		Arts__Crafts = 223,

		[Display(Name = "Sporting Goods")]
		[XmlEnum(Name = "Sporting Goods")]
		Sporting_Goods = 224,

		[Display(Name = "Farm Equipment")]
		[XmlEnum(Name = "Farm Equipment")]
		Farm_Equipment = 119,

		[Display(Name = "Electrical sales")]
		[XmlEnum(Name = "Electrical sales")]
		Electrical_sales = 117,

		[Display(Name = "Department store")]
		[XmlEnum(Name = "Department store")]
		Department_store = 115,

		[Display(Name = "Confectionary")]
		[XmlEnum(Name = "Confectionary")]
		Confectionary = 111,

		[Display(Name = "Carpeting/Rugs")]
		[XmlEnum(Name = "Carpeting/Rugs")]
		Carpeting_Rugs = 20,

		[Display(Name = "General retail")]
		[XmlEnum(Name = "General retail")]
		General_retail = 47,

		[Display(Name = "Shopping center")]
		[XmlEnum(Name = "Shopping center")]
		Shopping_center = 84,

		[Display(Name = "Computer store")]
		[XmlEnum(Name = "Computer store")]
		Computer_store = 22,

		[Display(Name = "Convenience store")]
		[XmlEnum(Name = "Convenience store")]
		Convenience_store = 24,

		[Display(Name = "Clothing store")]
		[XmlEnum(Name = "Clothing store")]
		Clothing_store = 25,

		[Display(Name = "Craft store")]
		[XmlEnum(Name = "Craft store")]
		Craft_store = 27,

		[Display(Name = "Diving shop")]
		[XmlEnum(Name = "Diving shop")]
		Diving_shop = 34,

		[Display(Name = "Florist/Gifts")]
		[XmlEnum(Name = "Florist/Gifts")]
		Florist_Gifts = 40,

		[Display(Name = "Frame shop")]
		[XmlEnum(Name = "Frame shop")]
		Frame_shop = 41,

		[Display(Name = "Food store")]
		[XmlEnum(Name = "Food store")]
		Food_store = 42,

		[Display(Name = "Furniture/household")]
		[XmlEnum(Name = "Furniture/household")]
		Furniture_household = 43,

		[Display(Name = "Hardware store")]
		[XmlEnum(Name = "Hardware store")]
		Hardware_store = 48,

		[Display(Name = "Ice Cream shop")]
		[XmlEnum(Name = "Ice Cream shop")]
		Ice_Cream_shop = 53,

		[Display(Name = "Outfitter")]
		[XmlEnum(Name = "Outfitter")]
		Outfitter = 239,

		[Display(Name = "Jewelry")]
		[XmlEnum(Name = "Jewelry")]
		Jewelry = 54,

		[Display(Name = "Moving/Trucking")]
		[XmlEnum(Name = "Moving/Trucking")]
		Moving_Trucking = 63,

		[Display(Name = "News/Magazines")]
		[XmlEnum(Name = "News/Magazines")]
		News_Magazines = 64,

		[Display(Name = "Office supplies")]
		[XmlEnum(Name = "Office supplies")]
		Office_supplies = 67,

		[Display(Name = "Pet & supplies")]
		[XmlEnum(Name = "Pet & supplies")]
		Pet__supplies = 69,

		[Display(Name = "Pharmacy")]
		[XmlEnum(Name = "Pharmacy")]
		Pharmacy = 70,

		[Display(Name = "Photography")]
		[XmlEnum(Name = "Photography")]
		Photography = 71,

		[Display(Name = "Plants/Nurseries")]
		[XmlEnum(Name = "Plants/Nurseries")]
		Plants_Nurseries = 73,

		[Display(Name = "Print shop")]
		[XmlEnum(Name = "Print shop")]
		Print_shop = 75,

		[Display(Name = "Security systems")]
		[XmlEnum(Name = "Security systems")]
		Security_systems = 82,

		[Display(Name = "Specialty shop")]
		[XmlEnum(Name = "Specialty shop")]
		Specialty_shop = 85,

		[Display(Name = "Video store")]
		[XmlEnum(Name = "Video store")]
		Video_store = 91,

		[Display(Name = "Specialty retail")]
		[XmlEnum(Name = "Specialty retail")]
		Specialty_retail = 94,

		[Display(Name = "Appliance sales")]
		[XmlEnum(Name = "Appliance sales")]
		Appliance_sales = 100,

		[Display(Name = "Audio sales")]
		[XmlEnum(Name = "Audio sales")]
		Audio_sales = 103,

		[Display(Name = "Lawn equipment")]
		[XmlEnum(Name = "Lawn equipment")]
		Lawn_equipment = 56,

		[Display(Name = "Cards/gifts")]
		[XmlEnum(Name = "Cards/gifts")]
		Cards_gifts = 19,

		[Display(Name = "Tobacco Store")]
		[XmlEnum(Name = "Tobacco Store")]
		Tobacco_Store = 243,

		[Display(Name = "Decorators/shops")]
		[XmlEnum(Name = "Decorators/shops")]
		Decorators_shops = 30,

		[Display(Name = "Parking Lot")]
		[XmlEnum(Name = "Parking Lot")]
		Parking_Lot = 242,

		[Display(Name = "Plumbing")]
		[XmlEnum(Name = "Plumbing")]
		Plumbing = 136,

		[Display(Name = "Miscellaneous services")]
		[XmlEnum(Name = "Miscellaneous services")]
		Miscellaneous_services = 214,

		[Display(Name = "Contract maintenance")]
		[XmlEnum(Name = "Contract maintenance")]
		Contract_maintenance = 113,

		[Display(Name = "Furniture repair")]
		[XmlEnum(Name = "Furniture repair")]
		Furniture_repair = 123,

		[Display(Name = "High Technology")]
		[XmlEnum(Name = "High Technology")]
		High_Technology = 96,

		[Display(Name = "High Tech")]
		[XmlEnum(Name = "High Tech")]
		High_Tech = 204,

		[Display(Name = "Entertainment")]
		[XmlEnum(Name = "Entertainment")]
		Entertainment = 38,

		[Display(Name = "Cinema/Theatre")]
		[XmlEnum(Name = "Cinema/Theatre")]
		Cinema_Theatre = 227,

		[Display(Name = "Disco")]
		[XmlEnum(Name = "Disco")]
		Disco = 33,

		[Display(Name = "Music")]
		[XmlEnum(Name = "Music")]
		Music = 61,

		[Display(Name = "Night club")]
		[XmlEnum(Name = "Night club")]
		Night_club = 65,

		[Display(Name = "Unknown")]
		[XmlEnum(Name = "Unknown")]
		Unknown = 252,

		[Display(Name = "Storage/Mini")]
		[XmlEnum(Name = "Storage/Mini")]
		Storage_Mini = 87,

		[Display(Name = "Residential/Commercial/Offices")]
		[XmlEnum(Name = "Residential/Commercial/Offices")]
		Residential_Commercial_Offices = 218,

		[Display(Name = "Cottage/Cabin Rental")]
		[XmlEnum(Name = "Cottage/Cabin Rental")]
		Cottage_Cabin_Rental = 220,

		[Display(Name = "Lingerie")]
		[XmlEnum(Name = "Lingerie")]
		Lingerie = 235,

		[Display(Name = "Pet Grooming")]
		[XmlEnum(Name = "Pet Grooming")]
		Pet_Grooming = 253,

		[Display(Name = "Recycling")]
		[XmlEnum(Name = "Recycling")]
		Recycling = 254,

		[Display(Name = "Day Spa")]
		[XmlEnum(Name = "Day Spa")]
		Day_Spa = 264,

		[Display(Name = "Marina/Resort")]
		[XmlEnum(Name = "Marina/Resort")]
		Marina_Resort = 265,

		[Display(Name = "School")]
		[XmlEnum(Name = "School")]
		School = 256,

		[Display(Name = "Bar/Hotel")]
		[XmlEnum(Name = "Bar/Hotel")]
		Bar_Hotel = 257,

		[Display(Name = "Beauty/Hair")]
		[XmlEnum(Name = "Beauty/Hair")]
		Beauty_Hair = 258,

		[Display(Name = "Daycare/Children")]
		[XmlEnum(Name = "Daycare/Children")]
		Daycare_Children = 259,

		[Display(Name = "Grocery/Mini Mart")]
		[XmlEnum(Name = "Grocery/Mini Mart")]
		Grocery_Mini_Mart = 260,

		[Display(Name = "Other Retail")]
		[XmlEnum(Name = "Other Retail")]
		Other_Retail = 261,

		[Display(Name = "Other Services")]
		[XmlEnum(Name = "Other Services")]
		Other_Services = 262,

		[Display(Name = "Packing Building")]
		[XmlEnum(Name = "Packing Building")]
		Packing_Building = 263,

		[Display(Name = "Wrapping")]
		[XmlEnum(Name = "Wrapping")]
		Wrapping = 232,

		[Display(Name = "Accounting")]
		[XmlEnum(Name = "Accounting")]
		Accounting = 229,

		[Display(Name = "Miscellanous services")]
		[XmlEnum(Name = "Miscellanous services")]
		Miscellanous_services = 181,

		[Display(Name = "Dry Cleaning/laundry")]
		[XmlEnum(Name = "Dry Cleaning/laundry")]
		Dry_Cleaning_laundry = 172,

		[Display(Name = "Electronics store")]
		[XmlEnum(Name = "Electronics store")]
		Electronics_store = 37,

		[Display(Name = "Marine equipment")]
		[XmlEnum(Name = "Marine equipment")]
		Marine_equipment = 58,

		[Display(Name = "Strip mall")]
		[XmlEnum(Name = "Strip mall")]
		Strip_mall = 88,

		[Display(Name = "Apartments")]
		[XmlEnum(Name = "Apartments")]
		Apartments = 1,

		[Display(Name = "Licensed student dwelling")]
		[XmlEnum(Name = "Licensed student dwelling")]
		Licensed_student_dwelling = 247,

		[Display(Name = "Mobile home park")]
		[XmlEnum(Name = "Mobile home park")]
		Mobile_home_park = 62,

		[Display(Name = "Residential")]
		[XmlEnum(Name = "Residential")]
		Residential = 158,

		[Display(Name = "Single tenant rental")]
		[XmlEnum(Name = "Single tenant rental")]
		Single_tenant_rental = 246,

		[Display(Name = "Townhouse / row unit rental")]
		[XmlEnum(Name = "Townhouse / row unit rental")]
		Townhouse___row_unit_rental = 248,

		[Display(Name = "Residential/Commercial")]
		[XmlEnum(Name = "Residential/Commercial")]
		Residential_Commercial = 159,

		[Display(Name = "Office/residential")]
		[XmlEnum(Name = "Office/residential")]
		Office_residential = 203,

		[Display(Name = "Special purpose")]
		[XmlEnum(Name = "Special purpose")]
		Special_purpose = 250,

		[Display(Name = "Specialized residence")]
		[XmlEnum(Name = "Specialized residence")]
		Specialized_residence = 241,

		[Display(Name = "Consultants")]
		[XmlEnum(Name = "Consultants")]
		Consultants = 23,

		[Display(Name = "Wholesale")]
		[XmlEnum(Name = "Wholesale")]
		Wholesale = 249,

		[Display(Name = "Dry cleaning")]
		[XmlEnum(Name = "Dry cleaning")]
		Dry_cleaning = 35,

		[Display(Name = "Laundromat")]
		[XmlEnum(Name = "Laundromat")]
		Laundromat = 55,

		[Display(Name = "Banquet hall")]
		[XmlEnum(Name = "Banquet hall")]
		Banquet_hall = 106,

		[Display(Name = "Gas station")]
		[XmlEnum(Name = "Gas station")]
		Gas_station = 44,

		[Display(Name = "Shoe repair")]
		[XmlEnum(Name = "Shoe repair")]
		Shoe_repair = 83,

		[Display(Name = "Trucking")]
		[XmlEnum(Name = "Trucking")]
		Trucking = 90,

		[Display(Name = "Appliance service")]
		[XmlEnum(Name = "Appliance service")]
		Appliance_service = 101,

		[Display(Name = "Audio service")]
		[XmlEnum(Name = "Audio service")]
		Audio_service = 104,

		[Display(Name = "Carpentry")]
		[XmlEnum(Name = "Carpentry")]
		Carpentry = 109,

		[Display(Name = "Electrical service")]
		[XmlEnum(Name = "Electrical service")]
		Electrical_service = 118,

		[Display(Name = "Haulage")]
		[XmlEnum(Name = "Haulage")]
		Haulage = 126,

		[Display(Name = "Kennel")]
		[XmlEnum(Name = "Kennel")]
		Kennel = 129,

		[Display(Name = "Taxi")]
		[XmlEnum(Name = "Taxi")]
		Taxi = 145,

		[Display(Name = "Television service/repairs")]
		[XmlEnum(Name = "Television service/repairs")]
		Television_service_repairs = 147,

		[Display(Name = "Travel agency")]
		[XmlEnum(Name = "Travel agency")]
		Travel_agency = 148,

		[Display(Name = "Laundry")]
		[XmlEnum(Name = "Laundry")]
		Laundry = 36,

		[Display(Name = "Liquor Store")]
		[XmlEnum(Name = "Liquor Store")]
		Liquor_Store = 266,

		[Display(Name = "Book store")]
		[XmlEnum(Name = "Book store")]
		Book_store = 12,

		[Display(Name = "Tourist")]
		[XmlEnum(Name = "Tourist")]
		Tourist = 221,

		[Display(Name = "Vegetable/fruit farm")]
		[XmlEnum(Name = "Vegetable/fruit farm")]
		Vegetable_fruit_farm = 210,

		[Display(Name = "Mixed use farm")]
		[XmlEnum(Name = "Mixed use farm")]
		Mixed_use_farm = 211,

		[Display(Name = "Breeding")]
		[XmlEnum(Name = "Breeding")]
		Breeding = 231,

		[Display(Name = "Maple Sugar Bush")]
		[XmlEnum(Name = "Maple Sugar Bush")]
		Maple_Sugar_Bush = 233,

		[Display(Name = "Fruits & Vegetables")]
		[XmlEnum(Name = "Fruits & Vegetables")]
		Fruits__Vegetables = 234,

		[Display(Name = "Feedlot")]
		[XmlEnum(Name = "Feedlot")]
		Feedlot = 120,

		[Display(Name = "Market garden")]
		[XmlEnum(Name = "Market garden")]
		Market_garden = 131,

		[Display(Name = "Cannabis")]
		[XmlEnum(Name = "Cannabis")]
		Cannabis = 268,

		[Display(Name = "Auto body")]
		[XmlEnum(Name = "Auto body")]
		Auto_body = 2,

		[Display(Name = "Automotive")]
		[XmlEnum(Name = "Automotive")]
		Automotive = 171,

		[Display(Name = "Auto parts")]
		[XmlEnum(Name = "Auto parts")]
		Auto_parts = 3,

		[Display(Name = "Auto sales")]
		[XmlEnum(Name = "Auto sales")]
		Auto_sales = 4,

		[Display(Name = "Auto service/repair")]
		[XmlEnum(Name = "Auto service/repair")]
		Auto_service_repair = 5,

		[Display(Name = "Car wash")]
		[XmlEnum(Name = "Car wash")]
		Car_wash = 18,

		[Display(Name = "Truck garage")]
		[XmlEnum(Name = "Truck garage")]
		Truck_garage = 97,

		[Display(Name = "Auto wreckers")]
		[XmlEnum(Name = "Auto wreckers")]
		Auto_wreckers = 105,

		[Display(Name = "Repair shop")]
		[XmlEnum(Name = "Repair shop")]
		Repair_shop = 139,

		[Display(Name = "Building lot/supplies")]
		[XmlEnum(Name = "Building lot/supplies")]
		Building_lot_supplies = 14,

		[Display(Name = "Construction")]
		[XmlEnum(Name = "Construction")]
		Construction = 112,

		[Display(Name = "Lumber")]
		[XmlEnum(Name = "Lumber")]
		Lumber = 180,

		[Display(Name = "Gravel yard")]
		[XmlEnum(Name = "Gravel yard")]
		Gravel_yard = 191,

		[Display(Name = "Bakery")]
		[XmlEnum(Name = "Bakery")]
		Bakery = 6,

		[Display(Name = "Pub")]
		[XmlEnum(Name = "Pub")]
		Pub = 77,

		[Display(Name = "Seafood sales")]
		[XmlEnum(Name = "Seafood sales")]
		Seafood_sales = 81,

		[Display(Name = "Coffee shop")]
		[XmlEnum(Name = "Coffee shop")]
		Coffee_shop = 110,

		[Display(Name = "Donut/Coffee shop")]
		[XmlEnum(Name = "Donut/Coffee shop")]
		Donut_Coffee_shop = 116,

		[Display(Name = "Frozen foods")]
		[XmlEnum(Name = "Frozen foods")]
		Frozen_foods = 122,

		[Display(Name = "Health foods")]
		[XmlEnum(Name = "Health foods")]
		Health_foods = 127,

		[Display(Name = "Meat packing")]
		[XmlEnum(Name = "Meat packing")]
		Meat_packing = 132,

		[Display(Name = "Tobacco farm")]
		[XmlEnum(Name = "Tobacco farm")]
		Tobacco_farm = 198,

		[Display(Name = "Sod farm")]
		[XmlEnum(Name = "Sod farm")]
		Sod_farm = 197,

		[Display(Name = "Potato farm")]
		[XmlEnum(Name = "Potato farm")]
		Potato_farm = 196,

		[Display(Name = "Tree farm")]
		[XmlEnum(Name = "Tree farm")]
		Tree_farm = 195,

		[Display(Name = "Boarding house")]
		[XmlEnum(Name = "Boarding house")]
		Boarding_house = 10,

		[Display(Name = "Hotel")]
		[XmlEnum(Name = "Hotel")]
		Hotel = 52,

		[Display(Name = "Hotel/motel")]
		[XmlEnum(Name = "Hotel/motel")]
		Hotel_motel = 187,

		[Display(Name = "Inn (6 bedrooms plus)")]
		[XmlEnum(Name = "Inn (6 bedrooms plus)")]
		Inn_6_bedrooms_plus = 225,

		[Display(Name = "Motel")]
		[XmlEnum(Name = "Motel")]
		Motel = 60,

		[Display(Name = "Agriculture")]
		[XmlEnum(Name = "Agriculture")]
		Agriculture = 244,

		[Display(Name = "Crop farm")]
		[XmlEnum(Name = "Crop farm")]
		Crop_farm = 26,

		[Display(Name = "Dairy farm")]
		[XmlEnum(Name = "Dairy farm")]
		Dairy_farm = 28,

		[Display(Name = "Horse farm")]
		[XmlEnum(Name = "Horse farm")]
		Horse_farm = 50,

		[Display(Name = "Poultry farm")]
		[XmlEnum(Name = "Poultry farm")]
		Poultry_farm = 74,

		[Display(Name = "Beef farm")]
		[XmlEnum(Name = "Beef farm")]
		Beef_farm = 152,

		[Display(Name = "Greenhouse")]
		[XmlEnum(Name = "Greenhouse")]
		Greenhouse = 153,

		[Display(Name = "Orchard")]
		[XmlEnum(Name = "Orchard")]
		Orchard = 154,

		[Display(Name = "Vineyard")]
		[XmlEnum(Name = "Vineyard")]
		Vineyard = 155,

		[Display(Name = "Nut shop")]
		[XmlEnum(Name = "Nut shop")]
		Nut_shop = 133,

		[Display(Name = "Aviary")]
		[XmlEnum(Name = "Aviary")]
		Aviary = 160,

		[Display(Name = "Berry farm")]
		[XmlEnum(Name = "Berry farm")]
		Berry_farm = 162,

		[Display(Name = "Fish farm")]
		[XmlEnum(Name = "Fish farm")]
		Fish_farm = 163,

		[Display(Name = "Fur farm")]
		[XmlEnum(Name = "Fur farm")]
		Fur_farm = 164,

		[Display(Name = "Hog farm")]
		[XmlEnum(Name = "Hog farm")]
		Hog_farm = 165,

		[Display(Name = "Mushroom farm")]
		[XmlEnum(Name = "Mushroom farm")]
		Mushroom_farm = 166,

		[Display(Name = "Nursery")]
		[XmlEnum(Name = "Nursery")]
		Nursery = 167,

		[Display(Name = "Sheep farm")]
		[XmlEnum(Name = "Sheep farm")]
		Sheep_farm = 168,

		[Display(Name = "Vegetable farm")]
		[XmlEnum(Name = "Vegetable farm")]
		Vegetable_farm = 169,

		[Display(Name = "Worm farm")]
		[XmlEnum(Name = "Worm farm")]
		Worm_farm = 170,

		[Display(Name = "Farm/ranch")]
		[XmlEnum(Name = "Farm/ranch")]
		Farm_ranch = 179,

		[Display(Name = "Exotic animal farm")]
		[XmlEnum(Name = "Exotic animal farm")]
		Exotic_animal_farm = 190,

		[Display(Name = "Mixed farm")]
		[XmlEnum(Name = "Mixed farm")]
		Mixed_farm = 192,

		[Display(Name = "Hobby farm")]
		[XmlEnum(Name = "Hobby farm")]
		Hobby_farm = 193,

		[Display(Name = "Goat farm")]
		[XmlEnum(Name = "Goat farm")]
		Goat_farm = 194,

		[Display(Name = "Bee farm")]
		[XmlEnum(Name = "Bee farm")]
		Bee_farm = 161,

		[Display(Name = "Boat sales")]
		[XmlEnum(Name = "Boat sales")]
		Boat_sales = 11,

		[Display(Name = "Grocery")]
		[XmlEnum(Name = "Grocery")]
		Grocery = 212,

		[Display(Name = "Butcher shop")]
		[XmlEnum(Name = "Butcher shop")]
		Butcher_shop = 15,

		[Display(Name = "Hairdressing Salon")]
		[XmlEnum(Name = "Hairdressing Salon")]
		Hairdressing_Salon = 228,

		[Display(Name = "Health Centre")]
		[XmlEnum(Name = "Health Centre")]
		Health_Centre = 230,

		[Display(Name = "Massotherapy")]
		[XmlEnum(Name = "Massotherapy")]
		Massotherapy = 237,

		[Display(Name = "Health club")]
		[XmlEnum(Name = "Health club")]
		Health_club = 49,

		[Display(Name = "Dating service")]
		[XmlEnum(Name = "Dating service")]
		Dating_service = 114,

		[Display(Name = "Tailor shop")]
		[XmlEnum(Name = "Tailor shop")]
		Tailor_shop = 89,

		[Display(Name = "Bowling alley")]
		[XmlEnum(Name = "Bowling alley")]
		Bowling_alley = 13,

		[Display(Name = "Campground")]
		[XmlEnum(Name = "Campground")]
		Campground = 16,

		[Display(Name = "Marina/Resort")]
		[XmlEnum(Name = "Marina/Resort")]
		Marina_Resort2 = 200,

		[Display(Name = "Marina")]
		[XmlEnum(Name = "Marina")]
		Marina = 57,

		[Display(Name = "Sports & Recreation")]
		[XmlEnum(Name = "Sports & Recreation")]
		Sports__Recreation = 86,

		[Display(Name = "Billiard")]
		[XmlEnum(Name = "Billiard")]
		Billiard = 107,

		[Display(Name = "Go Carts")]
		[XmlEnum(Name = "Go Carts")]
		Go_Carts = 124,

		[Display(Name = "Golf course")]
		[XmlEnum(Name = "Golf course")]
		Golf_course = 125,

		[Display(Name = "Recreation")]
		[XmlEnum(Name = "Recreation")]
		Recreation = 137,

		[Display(Name = "Bar/tavern")]
		[XmlEnum(Name = "Bar/tavern")]
		Bar_tavern = 7,

		[Display(Name = "Restaurant")]
		[XmlEnum(Name = "Restaurant")]
		Restaurant = 80,

		[Display(Name = "Deli")]
		[XmlEnum(Name = "Deli")]
		Deli = 31,

		[Display(Name = "Diner")]
		[XmlEnum(Name = "Diner")]
		Diner = 32,

		[Display(Name = "Fast foods")]
		[XmlEnum(Name = "Fast foods")]
		Fast_foods = 39,

		[Display(Name = "Pizza shop")]
		[XmlEnum(Name = "Pizza shop")]
		Pizza_shop = 72,

		[Display(Name = "Fish & Chips")]
		[XmlEnum(Name = "Fish & Chips")]
		Fish__Chips = 121,

		[Display(Name = "Sub shop")]
		[XmlEnum(Name = "Sub shop")]
		Sub_shop = 144,

		[Display(Name = "Restaurant/fast food")]
		[XmlEnum(Name = "Restaurant/fast food")]
		Restaurant_fast_food = 189,

		[Display(Name = "Restaurant/pub")]
		[XmlEnum(Name = "Restaurant/pub")]
		Restaurant_pub = 205,

		[Display(Name = "Restaurant/Bowling")]
		[XmlEnum(Name = "Restaurant/Bowling")]
		Restaurant_Bowling = 141,

		[Display(Name = "Hotel/Tavern")]
		[XmlEnum(Name = "Hotel/Tavern")]
		Hotel_Tavern = 128,

		[Display(Name = "Restaurant/Banquet")]
		[XmlEnum(Name = "Restaurant/Banquet")]
		Restaurant_Banquet = 140,

		[Display(Name = "Resort")]
		[XmlEnum(Name = "Resort")]
		Resort = 79,

		[Display(Name = "Tanning Salon")]
		[XmlEnum(Name = "Tanning Salon")]
		Tanning_Salon = 226,

		[Display(Name = "Beauty shop")]
		[XmlEnum(Name = "Beauty shop")]
		Beauty_shop = 219,

		[Display(Name = "Auction")]
		[XmlEnum(Name = "Auction")]
		Auction = 102,

		[Display(Name = "Bookkeeping")]
		[XmlEnum(Name = "Bookkeeping")]
		Bookkeeping = 108,

		[Display(Name = "Candy shop")]
		[XmlEnum(Name = "Candy shop")]
		Candy_shop = 17,

		[Display(Name = "Caterer")]
		[XmlEnum(Name = "Caterer")]
		Caterer = 21,

		[Display(Name = "General industrial")]
		[XmlEnum(Name = "General industrial")]
		General_industrial = 46,

		[Display(Name = "Heavy industrial")]
		[XmlEnum(Name = "Heavy industrial")]
		Heavy_industrial = 207,

		[Display(Name = "Industrial")]
		[XmlEnum(Name = "Industrial")]
		Industrial = 215,

		[Display(Name = "Industrial Commercial")]
		[XmlEnum(Name = "Industrial Commercial")]
		Industrial_Commercial = 98,

		[Display(Name = "Industrial hi tech")]
		[XmlEnum(Name = "Industrial hi tech")]
		Industrial_hi_tech = 251,

		[Display(Name = "Light industrial")]
		[XmlEnum(Name = "Light industrial")]
		Light_industrial = 208,

		[Display(Name = "Warehouse")]
		[XmlEnum(Name = "Warehouse")]
		Warehouse = 92,

		[Display(Name = "Factory")]
		[XmlEnum(Name = "Factory")]
		Factory = 236,

		[Display(Name = "Outside storage")]
		[XmlEnum(Name = "Outside storage")]
		Outside_storage = 245,

		[Display(Name = "Institution")]
		[XmlEnum(Name = "Institution")]
		Institution = 199,

		[Display(Name = "Day Care")]
		[XmlEnum(Name = "Day Care")]
		Day_Care = 29,

		[Display(Name = "Hospital")]
		[XmlEnum(Name = "Hospital")]
		Hospital = 51,

		[Display(Name = "Pastry Shop")]
		[XmlEnum(Name = "Pastry Shop")]
		Pastry_Shop = 238,

		[Display(Name = "Nursing home")]
		[XmlEnum(Name = "Nursing home")]
		Nursing_home = 66,

		[Display(Name = "Nursing/Hospital")]
		[XmlEnum(Name = "Nursing/Hospital")]
		Nursing_Hospital = 173,

		[Display(Name = "Retirement home")]
		[XmlEnum(Name = "Retirement home")]
		Retirement_home = 142,

		[Display(Name = "Manufacturing")]
		[XmlEnum(Name = "Manufacturing")]
		Manufacturing = 59,

		[Display(Name = "Manufacturing/Warehouse")]
		[XmlEnum(Name = "Manufacturing/Warehouse")]
		Manufacturing_Warehouse = 95,

		[Display(Name = "Manufacturing/wholesale")]
		[XmlEnum(Name = "Manufacturing/wholesale")]
		Manufacturing_wholesale = 188,

		[Display(Name = "Mixed - IC&I")]
		[XmlEnum(Name = "Mixed - IC&I")]
		Mixed___ICI = 216,

		[Display(Name = "Other")]
		[XmlEnum(Name = "Other")]
		Other = 99,

		[Display(Name = "Offices")]
		[XmlEnum(Name = "Offices")]
		Offices = 157,

		[Display(Name = "Distribution Road")]
		[XmlEnum(Name = "Distribution Road")]
		Distribution_Road = 240,

		[Display(Name = "General commercial")]
		[XmlEnum(Name = "General commercial")]
		General_commercial = 45,

		[Display(Name = "Professional office(s)")]
		[XmlEnum(Name = "Professional office(s)")]
		Professional_offices = 76,

		[Display(Name = "See remarks")]
		[XmlEnum(Name = "See remarks")]
		See_remarks = 93,

		[Display(Name = "Barber/beauty shop")]
		[XmlEnum(Name = "Barber/beauty shop")]
		Barber_beauty_shop = 8,

		[Display(Name = "Personal consumer service")]
		[XmlEnum(Name = "Personal consumer service")]
		Personal_consumer_service = 68,

		[Display(Name = "Religious")]
		[XmlEnum(Name = "Religious")]
		Religious = 78,

		[Display(Name = "Mobile Food and Beverage")]
		[XmlEnum(Name = "Mobile Food and Beverage")]
		Mobile_Food_and_Beverage = 267
    }
}