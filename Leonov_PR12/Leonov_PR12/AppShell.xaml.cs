using Leonov_PR12.ViewModels;
using Leonov_PR12.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Leonov_PR12
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
