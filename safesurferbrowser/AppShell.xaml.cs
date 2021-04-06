using safesurferbrowser.ViewModels;
using safesurferbrowser.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace safesurferbrowser
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Navigation.PushAsync(new LoginPage());
        }

    }
}
