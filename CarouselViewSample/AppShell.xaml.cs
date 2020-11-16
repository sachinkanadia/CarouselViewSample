using System;
using System.Collections.Generic;
using CarouselViewSample.ViewModels;
using CarouselViewSample.Views;
using Xamarin.Forms;

namespace CarouselViewSample
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
