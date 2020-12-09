using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            switch (Device.Idiom)
            {
                case TargetIdiom.Phone: 
                    MainPage = new View.Phone.MainView(); break;
                case TargetIdiom.Watch: break;
                case TargetIdiom.TV: break;
                case TargetIdiom.Tablet: break;
                case TargetIdiom.Desktop:
                    MainPage = new View.DeskTop.MainView(); break;
                default:
                    MainPage = new View.DeskTop.MainView(); break;
            }

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
