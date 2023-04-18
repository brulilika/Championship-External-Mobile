using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.ViewModel;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View
{	
	public partial class MatchDetailPage : ContentPage
	{
		private MatchDetailViewModel _matchDetailViewModel;
        public MatchDetailPage (Guid matchId)
		{
			InitializeComponent ();
			_matchDetailViewModel = new MatchDetailViewModel(matchId);
			BindingContext = _matchDetailViewModel;
        }
	}
}

