using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SimpleBlog.Data.Models
{
  public partial class BlogModel : DbContext
  {
    public BlogModel()
        : base("name=BlogModel")
    {
    }

    public virtual DbSet<BlogComment> BlogComments { get; set; }
    public virtual DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<BlogPost>()
          .HasMany(e => e.BlogComments)
          .WithRequired(e => e.BlogPost)
          .WillCascadeOnDelete(false);
    }
  }
}
