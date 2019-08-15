using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PartlyNewsy.Core
{
    public partial class InterestsTile : Frame
    {
        public InterestsTile()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty DisplayNameProperty = BindableProperty.Create(nameof(DisplayName), typeof(string), typeof(InterestsTile));

        public string DisplayName
        {
            get
            {
                var display = (string)GetValue(DisplayNameProperty);
                return !string.IsNullOrWhiteSpace(display) ? display.ToUpper() : display;
            }
            set
            {
                SetValue(DisplayNameProperty, value.ToUpper());
            }
        }

        public static readonly BindableProperty BackgroundImageUrlProperty = BindableProperty.Create(nameof(BackgroundImageUrl), typeof(string), typeof(InterestsTile));

        public string BackgroundImageUrl
        {
            get
            {
                return (string)GetValue(BackgroundImageUrlProperty);
            }
            set
            {
                SetValue(BackgroundImageUrlProperty, value);
            }
        }
    }
}
