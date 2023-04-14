using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship_External_Mobile;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.View;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.ViewModel.PartialViewModel
{
	public class HomePartialViewModel : BaseViewModel
    {
        #region Propriedades
        private INavigation _navigation;
        private List<Match> _nextMatchList;
        #endregion

        public HomePartialViewModel(INavigation navigation)
		{
            _navigation = navigation;
            NextMatchList = new List<Match>();
            LoadData();
        }

        #region Encapsulamento
        public List<Match> NextMatchList { get { return _nextMatchList; } set { _nextMatchList = value; OnPropertyChanged("NextMatchList"); } }
        #endregion

        #region Commands
        #endregion

        #region Funções
        public async Task LoadData()
        {
            try
            {
                NextMatchList.Add(new Match() { MatchCode = "#120", CompetitionCode = "Competição 02", TeamA = "TimeA", TeamB = "TimeB", Status = MatchStatusEnum.schedule, StartDate = "12/04/2023 10:30" });
                NextMatchList.Add(new Match() { MatchCode = "#121", CompetitionCode = "Competição 03", TeamA = "TimeC", TeamB = "TimeD", Status = MatchStatusEnum.going, StartDate = "12/04/2023 13:00" });
                NextMatchList.Add(new Match() { MatchCode = "#122", CompetitionCode = "Competição 04", TeamA = "TimeE", TeamB = "TimeF", Status = MatchStatusEnum.finished, StartDate = "12/04/2023 15:30" });
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }

        public async Task DetailPageFunction()
        {
            try
            {
                await _navigation.PushAsync(new MatchDetailPage(new Match() { MatchCode = "#120", CompetitionCode = "Competição 02", TeamA = "TimeA", TeamB = "TimeB", Status = MatchStatusEnum.schedule, StartDate = "12/04/2023 10:30" }));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }
        #endregion
    }
}

