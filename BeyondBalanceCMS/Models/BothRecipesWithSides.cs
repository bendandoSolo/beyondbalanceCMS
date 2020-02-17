using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace BeyondBalance.Models
{
    public class BothRecipesWithSides
    {
        public IEnumerable<RecipeWithPicture> rssCollection;
        public IEnumerable<RecipeWithPicture> rssCollection2;

        public BothRecipesWithSides(IEnumerable<RecipeWithPicture> firstRss, IEnumerable<RecipeWithPicture> secondRss)
        {
            rssCollection = firstRss;
            rssCollection2 = secondRss;
        }


        public static BothRecipesWithSides getFeeds(IEnumerable<RecipeWithPicture> firstRss, IEnumerable<RecipeWithPicture> secondRss)
        {
            BothRecipesWithSides feeds = new BothRecipesWithSides(firstRss, secondRss);
            return feeds;
        }




    }
}