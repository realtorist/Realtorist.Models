using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Realtorist.Models.Settings.Appearance.Theme;

namespace Realtorist.Models.Page
{
    /// <summary>
    /// Describes user-created page
    /// </summary>
    public class Page
    {
        /// <summary>
        /// Id of the page
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Indicates whether page is hidden for visitors
        /// </summary>
        [Display(Name = "Hide the page")]
        public bool UnPublished { get; set; }

        /// <summary>
        /// Link of the page
        /// </summary>
        [Required]
        [Display(Name ="Link")]
        [RegularExpression("[a-z0-9-]+", ErrorMessage = "Link can only contain lower case English character, digits and dashes (-)")]
        public string Link { get; set; }

        /// <summary>
        /// Title of the page
        /// </summary>
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        /// <summary>
        /// Keywords for the meta tag
        /// </summary>
        [Display(Name = "Keywords")]
        public string[] Keywords { get; set; }

        /// <summary>
        /// Desription for the meta tag
        /// </summary>
        [Display(Name = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Components on the page
        /// </summary>
        [Required]
        [Display(Name = "Page components")]
        public PageComponent[] Components { get; set; }

        /// <summary>
        /// Additional configuration
        /// </summary>
        /// <typeparam name="string">Key</typeparam>
        /// <typeparam name="object">Value</typeparam>
        public Dictionary<string, object> Configuration = new Dictionary<string, object>();

        /// <summary>
        /// Additional CSS for the page
        /// </summary>
        [Display(Name = "Additional CSS")]
        public string AdditionalCss { get; set; }

        /// <summary>
        /// Number of page views
        /// </summary>
        [Display(Name = "Number of views")]
        public int Views { get; set; }
    }
}