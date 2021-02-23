using Biblioteca.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Biblioteca
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()  //salvano il collegamento con il server di phpmyadmin e le volte successive che si andr� a fare un collegamento con il server si avr� gi� caricato
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DatabaseHelper.InitConnectionString();
            PathHelper.InitPaths();
        }
    }
}
