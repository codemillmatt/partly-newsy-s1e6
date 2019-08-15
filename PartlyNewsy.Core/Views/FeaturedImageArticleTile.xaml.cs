using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PartlyNewsy.Core
{
    public partial class FeaturedImageArticleTile : ContentView
    {
        public FeaturedImageArticleTile()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty FeaturedImageProperty = BindableProperty.Create(nameof(FeaturedImage), typeof(string), typeof(FeaturedImageArticleTile));

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

        public static readonly BindableProperty HeadlineProperty = BindableProperty.Create(nameof(Headline), typeof(string), typeof(FeaturedImageArticleTile));

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

        public static readonly BindableProperty CategoryProperty = BindableProperty.Create(nameof(Category), typeof(string), typeof(FeaturedImageArticleTile));

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

        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string), typeof(FeaturedImageArticleTile));

        public string Source
        {
            get
            {
                return (string)GetValue(SourceProperty);
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }
    }
}
