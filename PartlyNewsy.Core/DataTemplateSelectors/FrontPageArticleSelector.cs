using System;
using PartlyNewsy.Models;
using Xamarin.Forms;

namespace PartlyNewsy.Core
{
    public class FrontPageArticleSelector : DataTemplateSelector
    {
        DataTemplate featuredArticleTemplate = new DataTemplate(typeof(FeaturedImageArticleTile));
        DataTemplate horizontalArticleTemplate = new DataTemplate(typeof(HorizontalArticleTile));

        public FrontPageArticleSelector()
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (!(item is Article article))
                throw new Exception("You got this template selector bound to the wrong thing!");

            if (article.CurrentArticleCount == 0 || article.CurrentArticleCount % 4 == 0)
                return featuredArticleTemplate;

            return horizontalArticleTemplate;
        }
    }
}
