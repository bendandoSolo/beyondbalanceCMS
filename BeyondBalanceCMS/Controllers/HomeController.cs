using BeyondBalance.Extensions;
using BeyondBalance.Interfaces;
using BeyondBalance.Models;
using BeyondBalance.Providers;
using MalcolmWall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
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
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult HealthyRecipes(int MealsPage = 0, int SnacksPage = 0)
        {
            if (MealsPage < 0) { MealsPage = 0; }
            if (SnacksPage < 0) { SnacksPage = 0; }
            ViewBag.MealsPage = MealsPage;
            ViewBag.SnacksPage = SnacksPage;

            IEnumerable<SyndicationItem> latestMealsItems = _rssProvider.GetLatest(MealsPage);
            IEnumerable<SyndicationItem> latestMealsItems2 = _rssProvider2.GetLatest(SnacksPage);
            //should not be within controller
            List<RecipeWithPicture> recipes = new List<RecipeWithPicture>();
            List<RecipeWithPicture> recipes2 = new List<RecipeWithPicture>();
            foreach (SyndicationItem item in latestMealsItems) { recipes.Add(new RecipeWithPicture(item)); }
            foreach (SyndicationItem item in latestMealsItems2) { recipes2.Add(new RecipeWithPicture(item)); }
            BothRecipesWithSides newModel = BothRecipesWithSides.getFeeds(recipes, recipes2);
            return View(newModel);
        }

        public ActionResult MainMeals(int id)
        {
            int page = id / 4;
            int index = id % 4;
            var latestMealsItems = _rssProvider.GetLatest(page);

            SyndicationItem model = latestMealsItems.ElementAt(index);
            model = SyndicationItemExtensions.FormatText(model);


            return View(model);
        }



        public ActionResult BreakfastsAndSides(int id)
        {
            int page = id / 4;
            int index = id % 4;
            var latestMealsItems2 = _rssProvider2.GetLatest(page);

            SyndicationItem model = latestMealsItems2.ElementAt(index);
            model = SyndicationItemExtensions.FormatText(model);
            return View(model);
        }






        public ActionResult Contact()
        {
            var rootNode = _umbracoContext.ContentCache.GetById(1055);
            //ViewBag.Message = "Your contact page.";

            // rootNode.
            //return View("Test");

            return View(new Email());
        }



    }
}