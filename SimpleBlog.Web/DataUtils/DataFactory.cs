using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Web.DataUtils
{
  public class DataFactory : IDataFactory
  {

    public IList<Models.BlogPost> BlogPostsViewModel(IList<Data.Models.BlogPost> blogPostsDataModel)
    {
      var postsViewModel = new List<Models.BlogPost>();
      foreach (var post in blogPostsDataModel)
      {
        var blogPost = BlogPostViewModel(post);

        postsViewModel.Add(blogPost);

      }
      return postsViewModel;
    }

    /// <summary>
    /// Converts between the data model of a post and the view model
    /// </summary>
    /// <param name="blogPostDataModel"></param>
    /// <returns></returns>
    public Models.BlogPost BlogPostViewModel(Data.Models.BlogPost blogPostDataModel)
    {
      var blogPost = new Models.BlogPost()
      {
        Id = blogPostDataModel.BlogPostID,
        PublishedOn = blogPostDataModel.PublishedOn,
        Title = blogPostDataModel.Title,
        Body = blogPostDataModel.Body,
        CommentCount = blogPostDataModel.CommentCount
      };
      return blogPost;
    }

    public IList<Models.BlogComment> BlogCommentsViewModel(ICollection<Data.Models.BlogComment> blogCommentsDataModel)
    {
      var commentsViewModel = new List<Models.BlogComment>();
      foreach(var comment in blogCommentsDataModel)
      {
        var blogComment = new Models.BlogComment()
        {
          Id = comment.CommentID,
          Comment = comment.Comment,
          CommentedOn = comment.CommentedOn
        };
        commentsViewModel.Add(blogComment);
      }

      return commentsViewModel;

    }
  }
}