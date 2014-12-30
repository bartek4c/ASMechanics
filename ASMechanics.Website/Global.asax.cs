using ASMechanics.Website.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace ASMechanics.Website
{
    public class Global : Umbraco.Web.UmbracoApplication
    {
        protected override void OnApplicationStarting(object sender, EventArgs e)
        {
            base.OnApplicationStarting(sender, e);

            AutomapperConfiguration.Configure();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}