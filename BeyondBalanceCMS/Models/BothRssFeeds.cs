using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace BeyondBalance.Models
{
    public class BothRssFeeds
    {
        public IEnumerable<SyndicationItem> rssCollection;
        public IEnumerable<SyndicationItem> rssCollection2;

        //constructor creates model with both rss feeds
        public BothRssFeeds(IEnumerable<SyndicationItem> firstRss, IEnumerable<SyndicationItem> secondRss)
        {
            rssCollection = firstRss;
            rssCollection2 = secondRss;
        }


        public static BothRssFeeds getRssFeeds(IEnumerable<SyndicationItem> firstRss, IEnumerable<SyndicationItem> secondRss)
        {
            BothRssFeeds feeds = new BothRssFeeds(firstRss, secondRss);
            return feeds;
        }


    }



}