using SimpleBlog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Data.Services
{
  public interface IBlogRepository
  {
    IList<BlogPost> GetAll();

    BlogPost Get(int Id);
  }
}
