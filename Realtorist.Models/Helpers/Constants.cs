using Realtorist.Models.Enums.LookupTypes;

namespace Realtorist.Models.Helpers
{
    /// <summary>
    /// Contains constants
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Garage parking types
        /// </summary>
        public static readonly ParkingType[] GarageTypes = new[]
        {
            ParkingType.Attached_Garage,
            ParkingType.Garage,
            ParkingType.Heated_Garage,
            ParkingType.Integrated_Garage,
            ParkingType.Detached_Garage
        };

        /// <summary>
        /// Transaction types related to sale
        /// </summary>
        public static readonly TransactionType?[] SaleTypes = new TransactionType?[]
        {
            TransactionType.For_sale,
            TransactionType.For_sale_or_rent
        };

        /// <summary>
        /// Transaction types related to rent
        /// </summary>
        public static readonly TransactionType?[] RentTypes = new TransactionType?[]
        {
            TransactionType.For_rent,
            TransactionType.For_lease,
            TransactionType.For_sale_or_rent
        };

        /// <summary>
        /// Default limit for paginations
        /// </summary>
        public const int DefaultPaginationLimit = 24;

        /// <summary>
        /// Default radius in meters for coordinate search
        /// </summary>
        public const int DefaultMapRadiusMeters = 10000;

        /// <summary>
        /// 3-letter country code
        /// </summary>
        public const string CountryCode = "CAN";

        /// <summary>
        /// Name of the item in HttpContext to store <see cref="Listings.Settings"/>
        /// </summary>
        public const string SettingHttpContextItemName = "settings";

        /// <summary>
        /// Capacity for in-memory caches
        /// </summary>
        public const int InMemoryCacheCapacity = 10000;

        /// <summary>
        /// Average number of characters for the post summary
        /// </summary>
        public const int AverageCharactersPerSummarry = 500;

        /// <summary>
        /// Name of the cookie indacting whether person created an account
        /// </summary>
        public const string CreateAccountCookieName = "AccountCreated";
    }
}
