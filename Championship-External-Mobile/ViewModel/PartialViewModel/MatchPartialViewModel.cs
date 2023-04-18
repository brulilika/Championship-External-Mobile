using System;
using System.Collections.Generic;
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
                    MatchList = matches;
                }
                //MatchList.Add(new Match() { MatchCode="#120", CompetitionCode = "Competição 02", TeamA ="TimeA", TeamB="TimeB", Status=MatchStatusEnum.schedule, StartDate="12/04/2023 10:30"});
                //MatchList.Add(new Match() { MatchCode = "#121", CompetitionCode = "Competição 03", TeamA = "TimeC", TeamB = "TimeD", Status = MatchStatusEnum.going, StartDate = "12/04/2023 13:00" });
                //MatchList.Add(new Match() { MatchCode = "#122", CompetitionCode = "Competição 04", TeamA = "TimeE", TeamB = "TimeF", Status = MatchStatusEnum.finished, StartDate = "12/04/2023 15:30" });
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }
        #endregion
    }
}

