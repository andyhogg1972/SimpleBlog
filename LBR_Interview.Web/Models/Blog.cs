﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog.Web.Models
{
  public class Blog
  {
    public IList<BlogPost> Posts { get; set; }

  }
}