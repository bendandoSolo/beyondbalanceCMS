using BeyondBalance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Syndication;

namespace BeyondBalance.Providers.Dummy
{
    public class DummyRssProvider : IRssProvider
    {
        public IEnumerable<SyndicationItem> GetItems()
        {
            return new[] {
                new SyndicationItem {
                    PublishDate = DateTime.Now,
                    Title = new TextSyndicationContent("Dummy Entry"),
                    Content = new TextSyndicationContent("This is just dummy content")
                }
            };
        }
    }
}