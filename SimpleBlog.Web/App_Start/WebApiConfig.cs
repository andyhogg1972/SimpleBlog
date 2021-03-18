using SimpleBlog.Data.Services;
using SimpleBlog.Web.Business;
using SimpleBlog.Web.DataUtils;
using SimpleBlog.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using Unity;

namespace SimpleBlog.Web
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services
      var container = new UnityContainer();
      container.RegisterType<IBlogManager, BlogManager>();
      container.RegisterType<IBlogRepository, BlogRepository>();
      container.RegisterType<IDataFactory, DataFactory>();
      config.DependencyResolver = new UnityResolver(container);

      config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
      // Web API routes
      config.MapHttpAttributeRoutes();

      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );

    }
  }
}
