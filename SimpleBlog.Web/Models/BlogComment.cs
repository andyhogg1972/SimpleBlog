using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Web.Models
{
  public class BlogComment
  {
    public int Id { get; set; }
    public string Comment { get; set; }
    public DateTime CommentedOn { get; set; }
  }
}