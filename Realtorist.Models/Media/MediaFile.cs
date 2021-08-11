using System;

namespace Realtorist.Models.Media
{
    /// <summary>
    /// Describes upload file
    /// </summary>
    public class MediaFile 
    {
        /// <summary>
        /// Id of the file
        /// </summary>
        public string Id { get; set; }
        
        /// <summary>
        /// File's URL
        /// </summary>
        public string Url { get; set; } 

        /// <summary>
        /// File's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// File's URL
        /// </summary>
        public DateTime CreatedAt { get; set; } 

        /// <summary>
        /// File's size in bytes
        /// </summary>
        public long Size { get; set; }
    }
}