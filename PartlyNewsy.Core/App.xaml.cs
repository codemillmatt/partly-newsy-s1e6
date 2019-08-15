using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Auth;
using PartlyNewsy.Core;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PartlyNewsy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShellPage();

            Routing.RegisterRoute("articledetail", typeof(ArticleDetailPage));
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("android=b7857000-1ebc-4252-b73b-39db6ab680c2;" +
                  "ios=bd0701e6-b000-42e8-bf75-a390d2a2ee48;",
                  typeof(Auth));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
