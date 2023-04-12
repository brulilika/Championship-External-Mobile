using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View.PartialView.MainPage
{	
	public partial class MatchView : ContentView
	{
		private MatchPartialViewModel _matchPartialViewModel;
        public MatchView ()
		{
			InitializeComponent ();
            _matchPartialViewModel = new MatchPartialViewModel();
            BindingContext = _matchPartialViewModel;
        }
	}
}

