using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationBarHideBug
{
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
            button.Clicked += async (sender, e) => {
                await Navigation.PushAsync(new SecondPage());
            };
        }
    }
}

