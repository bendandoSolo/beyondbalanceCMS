using BeyondBalance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;
using System.Xml;

namespace BeyondBalance.Providers
{
    public class HealthyRecipesRssProvider : IRssProvider
    {
        string url = "http://beyondbalancerecipes.blogspot.co.uk/rss.xml";

        public IEnumerable<SyndicationItem> GetItems()
        {
            var rss = XmlReader.Create(url);
            var articles = SyndicationFeed.Load(rss);
            rss.Close();

            return articles.Items;
        }
    }


    public class BreakfastsAndSidesRssProvider : IRssProvider2
    {
        string url = "http://beyondbalancerecipes.blogspot.co.uk/feeds/posts/default/?q=|label:sides|label:dessert|label:desserts";

        public IEnumerable<SyndicationItem> GetItems()
        {
            var rss = XmlReader.Create(url);
            var articles = SyndicationFeed.Load(rss);
            rss.Close();
            return articles.Items;
        }
    }

    public class LunchAndDinnerRssProvider : IRssProvider
    {
        string url = "http://beyondbalancerecipes.blogspot.co.uk/feeds/posts/default/?q=label:lunch|label:dinner|label:breakfast";

        public IEnumerable<SyndicationItem> GetItems()
        {
            var rss = XmlReader.Create(url);
            var articles = SyndicationFeed.Load(rss);
            rss.Close();
            return articles.Items;
        }
    }

}