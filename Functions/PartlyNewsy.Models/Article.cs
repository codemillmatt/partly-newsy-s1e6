using System;

namespace PartlyNewsy.Models
{
    public class Article
    {
        public string FeaturedImage { get; set; }
        public string NewsProviderName { get; set; }
        public string NewsProviderImageUrl { get; set; }
        public DateTime DatePublished { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }        
        public string ArticleUrl { get; set; }
        public int CurrentArticleCount { get; set; }
    }
}
