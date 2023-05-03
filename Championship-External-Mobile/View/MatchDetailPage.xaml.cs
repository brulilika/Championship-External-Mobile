using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.ViewModel;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View
{	
	public partial class MatchDetailPage : ContentPage
	{
		private MatchDetailViewModel _matchDetailViewModel;
        private HomePartialViewModel _homePartialViewModel;
        private MatchPartialViewModel _matchPartialViewModel;
        public MatchDetailPage (Guid matchId, HomePartialViewModel homePartialViewModel =null, MatchPartialViewModel matchPartialViewModel = null)
		{
			InitializeComponent ();
			_matchDetailViewModel = new MatchDetailViewModel(matchId);
			BindingContext = _matchDetailViewModel;
            if (homePartialViewModel != null)
                _homePartialViewModel = homePartialViewModel;
            if (matchPartialViewModel != null)
                _matchPartialViewModel = matchPartialViewModel;
        }
        
        protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            if (_homePartialViewModel != null)
                await _homePartialViewModel.LoadData();
            if (_matchPartialViewModel != null)
                await _matchPartialViewModel.LoadData();
        }
    }
}

