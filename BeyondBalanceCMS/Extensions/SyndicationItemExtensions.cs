using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Text.RegularExpressions;
using System.IO;

namespace BeyondBalance.Extensions
{
    public static class SyndicationItemExtensions
    {
        public static IOrderedEnumerable<SyndicationItem> OrderByDate(this IEnumerable<SyndicationItem> items)
            => items.OrderByDescending(item => item.PublishDate);


        public static SyndicationItem FormatText(SyndicationItem currentItem) {
            SyndicationItem item = currentItem;

            TextSyndicationContent tsc = (TextSyndicationContent)item.Content;
            string itemContent = tsc.Text;

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(itemContent);

           // var fontdivs = doc.DocumentNode.SelectNodes("//div")

            
            var htmlNode = doc.DocumentNode.ChildNodes;//just a single div
            foreach (var node in    htmlNode){
                node.SetAttributeValue("style", "margin: 0 auto; text-align: left; padding-left:24px; padding-right: 24px;");
            }
            //htmlNode.SetAttributeValue("style", "margin: 0 auto; text-align: center;");

            //var mainDivs = doc.DocumentNode.SelectNodes("//span[@class='MsoNormal']");
            var htmlspans = doc.DocumentNode.SelectNodes("//span");
            if (htmlspans != null){
                foreach (var node in htmlspans){
                    node.SetAttributeValue("style", "");
                }
            }

            var htmldivs = doc.DocumentNode.SelectNodes("//div");
            if (htmldivs != null)
            {
                foreach (var node in htmldivs)
                {
                    node.SetAttributeValue("style", "");
                }
            }


            // var returnDoc = new HtmlAgilityPack.HtmlDocument();
            // returnDoc = (HtmlAgilityPack.HtmlDocument)htmlspans;

                //var htmlNodes2 = htmlNodes
                //foreach (var node in htmlNodes)
                //{


                //}

                //remove all font: tags
                // bool hasBeen
                //     string pattern = "\\s+";
                //string replacement = " ";
                //Regex rgx = new Regex(pattern);
                //string result = rgx.Replace(itemContent, replacement);

                //itemContent = result;
                using (StringWriter writer = new StringWriter())
            {
                doc.Save(writer);
                itemContent = writer.ToString();
            }
            //itemContent = doc.S ToString();

            item.Content = new TextSyndicationContent(itemContent);

            return item;
        }
    }
}