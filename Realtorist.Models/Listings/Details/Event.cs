using System;

namespace Realtorist.Models.Listings.Details
{
    /// <summary>
    /// Describes event for the propery
    /// </summary>
    public class Event
    {
        /// <summary>
        /// The open house start date and time
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// The open house End date and time
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Comments about the open house
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// URL to the Live Stream
        /// </summary>
        public string URL { get; set; }
    }
}