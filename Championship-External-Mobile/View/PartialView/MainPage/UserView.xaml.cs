using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;

namespace ChampionshipExternalMobile.View.PartialView.MainPage
{	
	public partial class UserView : ContentView
	{
		private UserPartialViewModel _userPartialViewModel;
        public UserView ()
		{
			InitializeComponent ();
            _userPartialViewModel = new UserPartialViewModel();
            BindingContext = _userPartialViewModel;
        }
	}
}

