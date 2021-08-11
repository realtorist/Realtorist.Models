using System;

namespace Realtorist.Models.Blog
{
    /// <summary>
    /// Blog post comment list model
    /// </summary>
    public class CommentListModel : Comment
    {
        /// <summary>
        /// Post ID
        /// </summary>
        public Guid PostId { get; set; }

        /// <summary>
        /// Title of the post to which this comment belongs
        /// </summary>
        public string PostTitle { get; set; }
    }
}