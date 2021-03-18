using SimpleBlog.Web.Models;
using SimpleBlog.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleBlog.Web.DataUtils;

namespace SimpleBlog.Web.Business
{
  public class BlogManager : IBlogManager
  {
    private readonly IBlogRepository _blogRepository;
    private readonly IDataFactory _dataFactory;
    public BlogManager(IBlogRepository blogRepository, IDataFactory dataFactory)
    {
      _blogRepository = blogRepository;
      _dataFactory = dataFactory;
    }
    

    public Blog GetAllBlogPosts()
    {
      var blogPosts = _blogRepository.GetAll();

      var blog = new Blog();
      blog.Posts = _dataFactory.BlogPostsViewModel(blogPosts);

      return blog;
    }

    public IList<BlogComment> GetAllCommentsForBlog(int BlogId)
    {
      throw new NotImplementedException();
    }

    public BlogPost GetBlogPostById(int Id)
    {
      var blogPost = _blogRepository.Get(Id);

      return _dataFactory.BlogPostViewModel(blogPost);
    }

    public BlogComment GetCommentById(int Id)
    {
      throw new NotImplementedException();
    }
  }
}