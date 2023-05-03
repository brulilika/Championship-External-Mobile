using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Championship_External_Mobile;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.Service;
using Xamarin.Essentials;

namespace ChampionshipExternalMobile.ViewModel.PartialViewModel
{
	public class MatchPartialViewModel : BaseViewModel
    {
        #region Propriedades
        private List<Match> _matchList;
        private Match _selectedMatch;
        #endregion

        public MatchPartialViewModel()
		{
            MatchList = new List<Match>();
            LoadData();
        }

        #region Encapsulamento
        public List<Match> MatchList { get { return _matchList; } set { _matchList = value; OnPropertyChanged("MatchList"); } }
        public Match SelectedMatch { get { return _selectedMatch; } set { _selectedMatch = value; OnPropertyChanged("SelectedMatch"); } }
        #endregion

        #region Commands
        #endregion

        #region Funções
        public async Task LoadData()
        {
            try
            {
                MatchService matchService = new MatchService();
                string userId = Preferences.Get("userId", "");
                List<Match> matches = await matchService.GetMatches(userId);
                if (matches != null)
                {
                    MatchList = matches.OrderBy(ob=>ob.Status).ToList();
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }
        #endregion
    }
}

