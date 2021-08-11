using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Settings
{
    /// <summary>
    /// Describes testimonial
    /// </summary>
    public class Testimonial
    {
        /// <summary>
        /// Name of the testimonial author
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Title of the testimonial author
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Text of the testimonial
        /// </summary>
        [Required]
        public string Text { get; set; }

        /// <summary>
        /// Photo of the testimonial author
        /// </summary>
        [Required]
        [Url]
        public string Photo { get; set; }
    }
}