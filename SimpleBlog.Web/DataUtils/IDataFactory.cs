using SimpleBlog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBlog.Web.DataUtils
{
  public interface IDataFactory
  {

    IList<BlogComment> BlogCommentsViewModel(ICollection<Data.Models.BlogComment> blogCommentsDataModel);

    IList<BlogPost> BlogPostsViewModel(IList<SimpleBlog.Data.Models.BlogPost> blogPostsDataModel);

    Models.BlogPost BlogPostViewModel(Data.Models.BlogPost blogPostDataModel);
  }
}
