using System;
using System.Collections.Generic;
using ChampionshipExternalMobile.ViewModel;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.View
{
    public partial class InitialBoard : ContentPage
    {
        private InitialBoardViewModel _initialBoardViewModel;
        public InitialBoard()
        {
            InitializeComponent();
            _initialBoardViewModel = new InitialBoardViewModel();
            BindingContext = _initialBoardViewModel;
        }

        void SfButton_Clicked(System.Object sender, System.EventArgs e)
        {
            Console.WriteLine("BOtao pao");
        }
    }
}

