using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.ViewModel;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View
{	
	public partial class LoginPage : ContentPage
	{
        private LoginPageViewModel _loginPageViewModel;
        public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
            _loginPageViewModel = new LoginPageViewModel(this.Navigation);
            BindingContext = _loginPageViewModel;
        }
	}
}

