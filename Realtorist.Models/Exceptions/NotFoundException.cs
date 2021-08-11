using System;
using System.Runtime.Serialization;

namespace Realtorist.Models.Exceptions
{
    /// <summary>
    /// Describes exception that is thrown when item is not found. Leads to 404 exception
    /// </summary>
    public class NotFoundException : Exception
    {
        public NotFoundException()
        {
        }

        public NotFoundException(string message) : base(message)
        {
        }

        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
