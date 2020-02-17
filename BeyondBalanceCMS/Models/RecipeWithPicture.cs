using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;

namespace BeyondBalance.Models
{
    public class RecipeWithPicture : SyndicationItem
    {
        public SyndicationItem syndicationItem;
        public String Title;
        public DateTimeOffset PublishDate;
        public System.Collections.ObjectModel.Collection<SyndicationCategory> Categories;
        public System.Collections.ObjectModel.Collection<String> CategoryStrings;
        public String PictureSRC;

        public RecipeWithPicture(SyndicationItem item)
        {
            Title= item.Title.Text;
            PublishDate = item.PublishDate;
            CategoryStrings = new System.Collections.ObjectModel.Collection<string>();
            foreach (var cat in item.Categories)
            {
                CategoryStrings.Add(cat.Name.ToString());
            }
            PictureSRC = getFirstPicture(item);
        }

        private string getFirstPicture(SyndicationItem item)
        {
            TextSyndicationContent tsc = (TextSyndicationContent)item.Content;
            string itemContent = tsc.Text;

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(itemContent);

            var nodes = doc.DocumentNode.SelectNodes("//img");
            var imageNode = doc.DocumentNode.SelectSingleNode("//img");
            if (imageNode == null) return "/Content/Images/Home/Services/Small/Nutrition2.jpg";
            else {
                return imageNode.GetAttributeValue("src", "/Content/Images/Home/Services/Small/Nutrition2.jpg");
            }

               // return 



            //throw new NotImplementedException();
        }
    }
}