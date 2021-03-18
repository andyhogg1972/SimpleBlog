namespace SimpleBlog.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BlogComment")]
    public partial class BlogComment
    {
        [Key]
        public int CommentID { get; set; }

        public int BlogPostID { get; set; }

        [Required]
        public string Comment { get; set; }

        public DateTime CommentedOn { get; set; }

        public virtual BlogPost BlogPost { get; set; }
    }
}
