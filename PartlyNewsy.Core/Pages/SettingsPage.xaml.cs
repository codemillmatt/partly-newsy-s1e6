using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace PartlyNewsy.Core
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        protected async void HandleLogin_Tapped(object sender, EventArgs e)
        {
            var authService = new AuthenticationService();

            var success = await authService.Login();

            string message = "";
            if (success)
                message = authService.AccessToken;
            else
                message = "oh oh";

            await DisplayAlert("access token", message, "ok");
        }
    }
}
