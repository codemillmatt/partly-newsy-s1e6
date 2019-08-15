using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PartlyNewsy.Models
{
    public class NewsCategory : INotifyPropertyChanged
    {
        public string DisplayName { get; set; }
        public string CategoryName { get; set; }
        public string BackgroundImageUrl { get; set; }

        bool isFavorite;
        public bool IsFavorite
        {
            get => isFavorite;
            set
            {
                isFavorite = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsFavorite)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;        
    }

    public class AllNewsCategories : List<NewsCategory>
    {        
        public AllNewsCategories()
        {
            AddRange(new NewsCategory[] {
                new NewsCategory { CategoryName = "Business", DisplayName = "Business".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/business.jpg" },
                new NewsCategory { CategoryName = "Entertainment", DisplayName = "Entertainment".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/entertainment.jpg" },
                new NewsCategory { CategoryName = "Entertainment_MovieAndTV", DisplayName = "Movies and TV".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/movie.jpg" },
                new NewsCategory { CategoryName = "Entertainment_Music", DisplayName = "Music".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/music.jpg" },
                new NewsCategory { CategoryName = "Health", DisplayName = "Health".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/health.jpg" },
                new NewsCategory { CategoryName = "Politics", DisplayName = "Politics".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/politics.jpg" },
                new NewsCategory { CategoryName = "Products", DisplayName = "Products".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/toy.jpg" },
                new NewsCategory { CategoryName = "ScienceAndTechnology", DisplayName = "Science and Tech".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/astronomy.jpg" },
                new NewsCategory { CategoryName = "Technology", DisplayName = "Technology".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/technology.jpg" },
                new NewsCategory { CategoryName = "Science", DisplayName = "Science".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/science.jpg" },
                new NewsCategory { CategoryName = "Sports", DisplayName = "Sports".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/sports.jpg" },
                new NewsCategory { CategoryName = "Sports_Golf", DisplayName = "Golf".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/golf.jpg" },
                new NewsCategory { CategoryName = "Sports_MLB", DisplayName = "MLB", BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/baseball.jpg" },
                new NewsCategory { CategoryName = "Sports_NBA", DisplayName = "NBA", BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/basketball.jpg" },
                new NewsCategory { CategoryName = "Sports_NFL", DisplayName = "NFL", BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/football.jpg" },
                new NewsCategory { CategoryName = "Sports_NHL", DisplayName = "NHL", BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/hockey.jpg" },
                new NewsCategory { CategoryName = "Sports_Soccer", DisplayName = "Soccer".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/soccer.jpg" },
                new NewsCategory { CategoryName = "Sports_Tennis", DisplayName = "Tennis".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/tennis.jpg" },
                new NewsCategory { CategoryName = "Sports_CFB", DisplayName = "College Football".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/cfb.jpg" },
                new NewsCategory { CategoryName = "Sports_CBB", DisplayName = "College Baseball".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/cbb.jpg" },
                new NewsCategory { CategoryName = "US", DisplayName = "US News".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/news.jpg" },
                new NewsCategory { CategoryName = "US_Northeast", DisplayName = "US Northeast News".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/vermont.jpg" },
                new NewsCategory { CategoryName = "US_South", DisplayName = "US South News".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/georgia.jpg" },
                new NewsCategory { CategoryName = "US_Midwest", DisplayName = "US Midwest News".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/wisconsin.jpg" },
                new NewsCategory { CategoryName = "US_West", DisplayName = "US West News".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/oregon.jpg" },
                new NewsCategory { CategoryName = "World", DisplayName = "World".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/europe.jpg" },
                new NewsCategory { CategoryName = "World_Africa", DisplayName = "Africa".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/africa.jpg" },
                new NewsCategory { CategoryName = "World_Americas", DisplayName = "Americas".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/mexico.jpg" },
                new NewsCategory { CategoryName = "World_Asia", DisplayName = "Asia".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/asia.jpg" },
                new NewsCategory { CategoryName = "World_Europe", DisplayName = "Europe".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/norway.jpg" },
                new NewsCategory { CategoryName = "World_MiddleEast", DisplayName = "Middle East".ToUpper(), BackgroundImageUrl = "https://partlynewsyfunctionsstor.blob.core.windows.net/thumbnails/middleeast.jpg" }
            });
        }
    }
}
