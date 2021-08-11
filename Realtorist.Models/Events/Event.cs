using System;

namespace Realtorist.Models.Events
{
    /// <summary>
    /// Describes an event that happended in the system
    /// </summary>
    public class Event 
    {
        /// <summary>
        /// Id of the event
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// When event has happend in UTC
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Event's message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Event's title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Type of the event
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Level of the event
        /// </summary>
        public EventLevel Level { get; set; }
    }
}