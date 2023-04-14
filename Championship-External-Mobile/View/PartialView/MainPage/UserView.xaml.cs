using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ChampionshipExternalMobile.ViewModel.PartialViewModel;
using ChampionshipExternalMobile.Model;

using Syncfusion.ListView.XForms;

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

        async void SfListView_ItemTapped(System.Object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            if (sender is SfListView lv)
                lv.SelectedItem = null;
            await _userPartialViewModel.UserFunctionCommands(e.ItemData as UserFunctions);
        }
    }
}

