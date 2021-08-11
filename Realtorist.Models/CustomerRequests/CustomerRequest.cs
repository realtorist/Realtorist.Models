using Realtorist.Models.Dto;
using System;

namespace Realtorist.Models.CustomerRequests
{
    /// <summary>
    /// Describes customer request
    /// </summary>
    public class CustomerRequest
    {
        /// <summary>
        /// Id of the request
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Marks whether the request is read
        /// </summary>
        public bool Read { get; set; }

        /// <summary>
        /// Date and time of the request in UTC
        /// </summary>
        public DateTime DateTimeUtc { get; set; }

        /// <summary>
        /// Request details
        /// </summary>
        public RequestInformationModel Request {get; set;}

        /// <summary>
        /// Replies
        /// </summary>
        public CustomerRequestReply[] Replies { get; set; } = new CustomerRequestReply[0];
    }
}
