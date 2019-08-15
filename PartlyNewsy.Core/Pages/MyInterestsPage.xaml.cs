using System;
using System.Collections.Generic;
using PartlyNewsy.Models;
using Xamarin.Forms;

namespace PartlyNewsy.Core
{
    public partial class MyInterestsPage : ContentPage
    {
        public MyInterestsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            newsCategories.ItemsSource = new AllNewsCategories();
        }
    }
}
