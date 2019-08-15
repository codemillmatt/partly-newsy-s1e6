using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PartlyNewsy.Core
{
    public partial class HorizontalArticleTile : ContentView
    {
        public HorizontalArticleTile()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty FeaturedImageProperty = BindableProperty.Create(nameof(FeaturedImage), typeof(string), typeof(HorizontalArticleTile));

        public string FeaturedImage
        {
            get
            {
                return (string)GetValue(FeaturedImageProperty);
            }
            set
            {
                SetValue(FeaturedImageProperty, value);
            }
        }

        public static readonly BindableProperty HeadlineProperty = BindableProperty.Create(nameof(Headline), typeof(string), typeof(HorizontalArticleTile));

        public string Headline
        {
            get
            {
                return (string)GetValue(HeadlineProperty);
            }
            set
            {
                SetValue(HeadlineProperty, value);
            }
        }

        public static readonly BindableProperty CategoryProperty = BindableProperty.Create(nameof(Category), typeof(string), typeof(HorizontalArticleTile));

        public string Category
        {
            get
            {
                return (string)GetValue(CategoryProperty);
            }
            set
            {
                SetValue(CategoryProperty, value);
            }
        }

        public static readonly BindableProperty NewsProviderNameProperty = BindableProperty.Create(nameof(NewsProviderName), typeof(string), typeof(HorizontalArticleTile));

        public string NewsProviderName
        {
            get
            {
                return (string)GetValue(NewsProviderNameProperty);
            }
            set
            {
                SetValue(NewsProviderNameProperty, value);
            }
        }
    }
}
