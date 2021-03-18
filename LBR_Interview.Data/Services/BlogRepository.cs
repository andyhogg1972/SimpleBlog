using SimpleBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Data.Services
{
  public class BlogRepository : IBlogRepository
  {
    private readonly BlogModel db;
    public BlogRepository()
    {
      db = new BlogModel();
    }
    public BlogPost Get(int Id)
    {
      return db.BlogPosts.FirstOrDefault(r => r.BlogPostID == Id);
    }

    public IList<BlogPost> GetAll()
    {
      return db.BlogPosts.ToList();
    }

  }
}
