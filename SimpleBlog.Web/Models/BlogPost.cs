using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Web.Models
{
  public class BlogPost
  {
    public int Id { get; set; }

    public string Title { get; set; }

    public string Body { get; set; }

    public int CommentCount { get; set; }

    public DateTime PublishedOn { get; set; }
  }
}