using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace SimpleBlog.Web.DataUtils.Tests
{
  [TestClass()]
  public class DataFactoryTests
  {
    [TestMethod()]
    public void BlogPostsViewModelTest()
    {

      IDataFactory _dataFactory = new DataFactory();
      IList<Models.BlogPost> blogPosts = new List<Models.BlogPost>();
      IList<Data.Models.BlogPost> blogPostsDataModel = new List<Data.Models.BlogPost>();
      blogPostsDataModel.Add(new Data.Models.BlogPost() { BlogPostID = 0, Body = "jkh kh kjh k ", PublishedOn = DateTime.Now, Title = "Post 1", BlogComments = new List<Data.Models.BlogComment>() });
      blogPostsDataModel.Add(new Data.Models.BlogPost() { BlogPostID = 1, Body = "jkh kh kjh k ", PublishedOn = DateTime.Now, Title = "Post 1", BlogComments = new List<Data.Models.BlogComment>() });

      blogPosts = _dataFactory.BlogPostsViewModel(blogPostsDataModel);

      Assert.IsTrue(blogPosts.Count == 2);
    }
  }
}