using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship_External_Mobile;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.View;
using ChampionshipExternalMobile.Service;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Linq;

namespace ChampionshipExternalMobile.ViewModel.PartialViewModel
{
	public class HomePartialViewModel : BaseViewModel
    {
        #region Propriedades
        private INavigation _navigation;
        private GridLength _gridRowdefinition;
        private List<Match> _nextMatchList;
        private Match _onGoingMatch;
        private bool _onGoingCard;
        #endregion

        public HomePartialViewModel(INavigation navigation)
		{
            _navigation = navigation;
            NextMatchList = new List<Match>();
            LoadData();
        }

        #region Encapsulamento
        public GridLength GridRowdefinition { get { return _gridRowdefinition; } set { _gridRowdefinition = value; OnPropertyChanged("GridRowdefinition"); } }
        public List<Match> NextMatchList { get { return _nextMatchList; } set { _nextMatchList = value; OnPropertyChanged("NextMatchList"); } }
        public Match OnGoingMatch { get { return _onGoingMatch; } set { _onGoingMatch = value; OnPropertyChanged("OnGoingMatch"); } }
        public bool OnGoingCard { get { return _onGoingCard; } set { _onGoingCard = value; OnPropertyChanged("OnGoingCard"); } }
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
                    NextMatchList = matches.Take(5).ToList();
                    OnGoingMatch = matches.Where(w => w.Status == MatchStatusEnum.OnGoing)?.FirstOrDefault();
                    OnGoingCard = OnGoingMatch == null ? false : true;
                    if (!OnGoingCard)
                        GridRowdefinition = new GridLength(1,GridUnitType.Auto);
                }
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
                //await _navigation.PushAsync(new MatchDetailPage(new Match() { MatchCode = "#120", CompetitionCode = "Competição 02", TeamA = "TimeA", TeamB = "TimeB", Status = MatchStatusEnum.schedule, StartDate = "12/04/2023 10:30" }));
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }
        #endregion
    }
}

