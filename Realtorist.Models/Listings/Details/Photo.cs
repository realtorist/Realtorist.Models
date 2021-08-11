using System;
using System.Diagnostics.CodeAnalysis;

namespace Realtorist.Models.Listings.Details
{
    public class Photo
    {
        /// <summary>
        /// Description of the photo
        /// </summary>
        [MaybeNull]
        public string Description { get; set; }

        /// <summary>
        /// Image Url
        /// </summary>
        [MaybeNull]
        public string Url { get; set; }
    }
}