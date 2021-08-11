using System;
using Realtorist.Models.Enums.LookupTypes;

namespace Realtorist.Models.Models
{
    /// <summary>
    /// <see cref="Coordinates"/> with Listing ID
    /// </summary>
    public class ListingCoordinates : Coordinates
    {
        /// <summary>
        /// Listing ID
        /// </summary>
        public Guid ListingId { get; set; }

        /// <summary>
        /// Type of the property
        /// </summary>
        public PropertyType Type { get; set; }
    }
}
