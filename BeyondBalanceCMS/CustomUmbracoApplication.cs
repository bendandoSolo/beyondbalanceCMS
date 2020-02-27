using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;

namespace BeyondBalanceCMS
{
    public class CustomUmbracoApplication : UmbracoApplication
    {
        protected override IBootManager GetBootManager()
        {
            return new CustomWebBootManager(this);
        }
    }

    class CustomWebBootManager : WebBootManager
    {
        public CustomWebBootManager(UmbracoApplicationBase application):base(application) 
        {

        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            /*RouteTable.Routes.MapRoute(
                    "HomePage",
                    "home/index",
                    new {controller = "Home", action = "Index"}
            );*/
            RouteTable.Routes.MapRoute(
                   "Contact",
                   "home/contact",
                   new { controller = "Home", action = "contact" }
           );

            RouteTable.Routes.MapRoute(
                   "Home",
                   "home/PrivacyPolicy",
                   new { controller = "Home", action = "PrivacyPolicy" }
           );


            RouteTable.Routes.MapRoute(
                   "HealthyRecipies",
                   "home/healthyRecipes",
                   new { controller = "Home", action = "HealthyRecipes" }
           );
            RouteTable.Routes.MapRoute(
                 "MainMealsGeneral",
                 "home/MainMeals/{id}",
                  //new { controller = "Home", action = "Index" }
                  new { controller = "Home", action = "MainMeals" }
         );
            RouteTable.Routes.MapRoute(
                  "BreakfastsAndSides",
                  "home/BreakfastsAndSides/{id}",
                  new { controller = "Home", action = "BreakfastsAndSides",  }
          );

            return base.Complete(afterComplete);
        }


    }





}