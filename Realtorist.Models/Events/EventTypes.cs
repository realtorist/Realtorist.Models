namespace Realtorist.Models.Events
{
    /// <summary>
    /// Contains default event types
    /// </summary>
    public static class EventTypes
    {
        /// <summary>
        /// Generic event
        /// </summary>
        public const string Generic = "generic";

        /// <summary>
        /// Listings update
        /// </summary>
        public const string ListingUpdate = "listingUpdate";

        /// <summary>
        /// Customer's request created
        /// </summary>
        public const string CustomerRequest = "customerRequest";

        /// <summary>
        /// Account created
        /// </summary>
        public const string AccountCreated = "accountCreated";

        /// <summary>
        /// URL NotFound event (404)
        /// </summary>
        public const string UrlNotFound = "urlNotFound";
    }
}