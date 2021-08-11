using Realtorist.Models.Dto;
using System;

namespace Realtorist.Models.CustomerRequests
{
    /// <summary>
    /// Describes customer request reply
    /// </summary>
    public class CustomerRequestReply
    {
        /// <summary>
        /// Id of the reply
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Marks whether the request is read
        /// </summary>
        public bool Read { get; set; }

        /// <summary>
        /// Marks whether the request is read
        /// </summary>
        public bool FromCustomer { get; set; }

        /// <summary>
        /// Date and time of the reply in UTC
        /// </summary>
        public DateTime DateTimeUtc { get; set; }

        /// <summary>
        /// Reply message
        /// </summary>
        public string Message { get; set; }
    }
}
