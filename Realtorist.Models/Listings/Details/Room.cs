using System.Diagnostics.CodeAnalysis;
using Realtorist.Models.Attributes;
using Realtorist.Models.Enums.LookupTypes;
using Realtorist.Models.Xml;

namespace Realtorist.Models.Listings.Details
{
    public class Room
    {
        /// <summary>
        /// Type of room
        /// </summary>
        [DisplayableProperty]
        public RoomType? Type { get; set; }

        /// <summary>
        /// The level of the room
        /// </summary>
        [DisplayableProperty]
        public RoomLevel? Level { get; set; }

        /// <summary>
        /// General description of the room
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        public string Description { get; set; }

        /// <summary>
        /// The dimensions of the room
        /// </summary>
        [MaybeNull]
        [DisplayableProperty]
        public string Dimension { get; set; }
    }
}