using BeyondBalance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace BeyondBalance.Extensions
{
    public static class RssProviderExtensions
    {
        public static IEnumerable<SyndicationItem> GetLatest(this IRssProvider provider, int index){
            if (index == 0)
            return provider.GetItems().OrderByDate().Take(4); 
            else{
                int noOfItems = provider.GetItems().Count();
                if (index*4 + 4 < noOfItems )return provider.GetItems().OrderByDate().Skip(index*4).Take(4);
                else return provider.GetItems().OrderByDate().Skip(noOfItems-4).Take(4);
            }
        }

        public static IEnumerable<SyndicationItem> GetLatestOne(this IRssProvider provider)
        {
                return provider.GetItems().OrderByDate().Take(1);
        }

        public static IEnumerable<SyndicationItem> GetLatest(this IRssProvider2 provider, int index){
            if (index == 0)
                return provider.GetItems().OrderByDate().Take(4);
            else
            {
                int noOfItems = provider.GetItems().Count();
                if (index * 4 + 4 < noOfItems) return provider.GetItems().OrderByDate().Skip(index * 4).Take(4);
                else return provider.GetItems().OrderByDate().Skip(noOfItems - 4).Take(4);
            }
        }

        public static IEnumerable<SyndicationItem> GetLatestOne(this IRssProvider2 provider)
        {
            return provider.GetItems().OrderByDate().Take(1);
        }

    }
}