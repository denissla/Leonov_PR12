using Leonov_PR12.Services;
using Leonov_PR12.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Leonov_PR12
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
