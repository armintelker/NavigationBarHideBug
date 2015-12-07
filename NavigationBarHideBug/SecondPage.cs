using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationBarHideBug
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            button.Clicked += async (object sender, EventArgs e) => {
                await Navigation.PopAsync();
            };
        }
    }
}

