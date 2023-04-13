using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View.PartialView.MainPage
{	
	public partial class HomeView : ContentView
	{
		private HomePartialViewModel _homePartialViewModel;
        public HomeView ()
		{
			InitializeComponent ();
			_homePartialViewModel = new HomePartialViewModel();
			BindingContext = _homePartialViewModel;
        }
	}
}

