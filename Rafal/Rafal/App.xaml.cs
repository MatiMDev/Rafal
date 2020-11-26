using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rafal
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CreateOrderPage();
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
