 Visual Studio has added the full set of dependencies for ASP.NET MVC 5 to project 'mvcEticaret'. 

The Global.asax.cs file in the project may require additional changes to enable ASP.NET MVC.

1. Add the following namespace references:

    using System.Web.Mvc;
    using System.Web.Routing;
    using System.Web.Optimization;

2. If the code does not already define an Application_Start method, add the following method:

    protected void Application_Start()
    {
    }

3. Add the following lines to the end of the Application_Start method:

    AreaRegistration.RegisterAllAreas();
    RouteConfig.RegisterRoutes(RouteTable.Routes);
    FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
    BundleConfig2.RegisterBundles(BundleTable.Bundles);