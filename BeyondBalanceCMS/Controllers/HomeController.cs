using BeyondBalance.Interfaces;
using BeyondBalance.Providers;
using MalcolmWall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web;

namespace BeyondBalanceCMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRssProvider _rssProvider;
        private readonly IRssProvider2 _rssProvider2;
        private readonly UmbracoContext _umbracoContext;

        public HomeController() //IRssProvider rssProvider, IRssProvider2 rssProvider2)
        {
            _rssProvider = new LunchAndDinnerRssProvider();
            _rssProvider2 = new BreakfastsAndSidesRssProvider();
            _umbracoContext = UmbracoContext.Current;

        }




        // GET: Home
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Contact()
        {
            var rootNode = _umbracoContext.ContentCache.GetById(1055);
            //ViewBag.Message = "Your contact page.";

            // rootNode.

            return View("Test");

            //return View(new Email());
        }



    }
}