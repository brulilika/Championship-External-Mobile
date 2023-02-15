using System;
using ChampionshipExternalMobile.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Championship_External_Mobile
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InitialBoard());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

