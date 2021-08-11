using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtorist.Models.Blog
{
    /// <summary>
    /// Blog post comment
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// Comment ID
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Publish date and time
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Comment's author
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Author's email
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Comment content
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Message { get; set; }
    }
}
