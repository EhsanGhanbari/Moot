using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Moot.Service;
using Moot.UI.App_Start;
using Moot.UI.IOC;

namespace Moot.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);




            //IOC Config
            ControllerBuilder.Current.SetControllerFactory(new NinjectDependencyResolver());


            //Mapper Config
            AutoMapperBootStrapper.ConfigureAutoMapper();


        }
    }
}