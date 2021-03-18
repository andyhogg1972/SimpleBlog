using SimpleBlog.Web.Business;
using SimpleBlog.Web.Models;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleBlog.Web.Controllers
{
  public class BlogPostsController : ApiController
  {
    IBlogManager _blogManager;

    public BlogPostsController(IBlogManager blogManager)
    {
      _blogManager = blogManager;
    }

    /// <summary>
    /// Endpoint for all blog posts.
    /// </summary>
    /// <returns>HttpResponseMessage</returns>
    // GET api/blogposts
    [HttpGet]
    public HttpResponseMessage Get()
    {
      var blog = _blogManager.GetAllBlogPosts();

      return Request.CreateResponse<Blog>(HttpStatusCode.OK, blog); 
    }

    /// <summary>
    /// Endpoint for specific blog post by Id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    // GET api/blogposts/5
    [HttpGet]
    public HttpResponseMessage Get(int id)
    {
      var blogpost = _blogManager.GetBlogPostById(id);
      return Request.CreateResponse<BlogPost>(HttpStatusCode.OK, blogpost);
    }

  }
}