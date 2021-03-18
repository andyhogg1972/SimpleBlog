using SimpleBlog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Web.Business
{
  public interface IBlogManager
  {
    Blog GetAllBlogPosts();

    BlogPost GetBlogPostById(int Id);

    IList<BlogComment> GetAllCommentsForBlog(int BlogId);

    BlogComment GetCommentById(int Id);

  }
}
