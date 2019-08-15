using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PartlyNewsy.Models;
using Xamarin.Forms;

namespace PartlyNewsy.Core
{    
    public partial class NewsCollectionPage : ContentPage
    {
        public NewsCollectionPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await GetData();
        }

        async Task GetData()
        {
            var svc = new NewsService();

            var articles = await svc.GetTopNews();

            newsList.ItemsSource = articles;
        }

        protected async void newsListItemSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection[0] is Article article)
            {
                var url = Uri.EscapeDataString(article.ArticleUrl);

                await Shell.Current.GoToAsync($"articledetail?articleUrl={url}", true);

                //newsList.SelectedItem = null;
            } 
        }        
    }
}
