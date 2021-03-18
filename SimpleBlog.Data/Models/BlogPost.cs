namespace SimpleBlog.Data.Models
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Data.Entity.Spatial;

  [Table("BlogPosts")]
  public partial class BlogPost
  {
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public BlogPost()
    {
      BlogComments = new HashSet<BlogComment>();
    }

    public int BlogPostID { get; set; }

    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [Required]
    public string Body { get; set; }

    public DateTime PublishedOn { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BlogComment> BlogComments { get; set; }

    public int CommentCount
    {
      get { return BlogComments.Count; }
    }
  }
}
