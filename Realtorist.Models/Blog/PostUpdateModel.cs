using System;
using System.ComponentModel.DataAnnotations;

namespace Realtorist.Models.Blog
{
    /// <summary>
    /// Describes update model for the blog post
    /// </summary>
    public class PostUpdateModel
    {
        /// <summary>
        /// Post link
        /// </summary>
        [Required]
        [Display(Name ="Link")]
        [RegularExpression("[a-z0-9-]+", ErrorMessage = "Link can only contain lower case English character, digits and dashes (-)")]
        public string Link { get; set; }

        /// <summary>
        /// Post title
        /// </summary>
        [Required]
        [Display(Name ="Title")]
        public string Title { get; set; }

        /// <summary>
        /// Post sub title
        /// </summary>
        [Display(Name ="Sub title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// Post content
        /// </summary>
        [Required]
        [Display(Name ="Text")]
        public string Text { get; set; }

        /// <summary>
        /// Post title image
        /// </summary>
        [Required]
        [Url]
        [Display(Name ="Featured Image")]
        public string Image { get; set; }

        /// <summary>
        /// Publish date and time
        /// </summary>
        [Display(Name ="Publish Date")]
        public DateTime PublishDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Category of the post
        /// </summary>
        [Required]
        [Display(Name ="Category")]
        public string Category { get; set; }

        /// <summary>
        /// Tags of the post
        /// </summary>
        [Display(Name ="Tags")]
        public string[] Tags { get; set; } = new string[0];
    }
}