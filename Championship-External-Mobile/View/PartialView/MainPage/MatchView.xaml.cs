using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;
using Syncfusion.ListView.XForms;
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

        void SfListView_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            if (sender is SfListView lv)
                lv.SelectedItem = null;
            this.Navigation.PushAsync(new MatchDetailPage(e.ItemData as Match));
        }
    }
}

