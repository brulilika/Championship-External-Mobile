using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;
using Syncfusion.ListView.XForms;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View.PartialView.MainPage
{	
	public partial class HomeView : ContentView
	{
		private HomePartialViewModel _homePartialViewModel;
        public HomeView ()
		{
			InitializeComponent ();
			_homePartialViewModel = new HomePartialViewModel(this.Navigation);
			BindingContext = _homePartialViewModel;
        }

        void SfListView_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            if (sender is SfListView lv)
                lv.SelectedItem = null;
            this.Navigation.PushAsync(new MatchDetailPage((e.ItemData as Match).Id,_homePartialViewModel));
        }

        async void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            await _homePartialViewModel.DetailPageFunction();
        }
    }
}

