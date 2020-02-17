using BeyondBalance.Extensions;
using BeyondBalance.Interfaces;
using BeyondBalance.Models;
using BeyondBalance.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace BeyondBalanceCMS.Providers
{
    public static class LatestHealthyRecipes
    {
        public static BothRecipesWithSides getLatestTwoRecipes()
        {
            IRssProvider _rssProvider = new LunchAndDinnerRssProvider();
            IRssProvider2 _rssProvider2 = new BreakfastsAndSidesRssProvider();
            IEnumerable<SyndicationItem> latestMealsItems = _rssProvider.GetLatestOne();
            IEnumerable<SyndicationItem> latestMealsItems2 = _rssProvider2.GetLatestOne();
            List<RecipeWithPicture> recipes = new List<RecipeWithPicture>();
            List<RecipeWithPicture> recipes2 = new List<RecipeWithPicture>();
            foreach (SyndicationItem item in latestMealsItems) { recipes.Add(new RecipeWithPicture(item)); }
            foreach (SyndicationItem item in latestMealsItems2) { recipes2.Add(new RecipeWithPicture(item)); }
            BothRecipesWithSides newModel = BothRecipesWithSides.getFeeds(recipes, recipes2);
            return newModel;
        }
    }
}