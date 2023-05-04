using System;
using ChampionshipExternalMobile.Model;
using Championship_External_Mobile;
using System.Threading.Tasks;
using Xamarin.Forms;
using ChampionshipExternalMobile.View;
using ChampionshipExternalMobile.Service;
using System.Diagnostics;
using ChampionshipExternalMobile.Model.Request;

namespace ChampionshipExternalMobile.ViewModel
{
	public class MatchDetailViewModel : BaseViewModel
	{
        #region Propriedades
        private Guid _matchId;
        private bool _statusVisibleOnGoing;
        private bool _statusVisibleStart;
        private MatchDetail _matchDetail;
        private Command _startCommand;
        private Command _finishCommand;
        private Command _occurrenceCommand;
        #endregion

        public MatchDetailViewModel(Guid matchId)
		{
            _matchId = matchId;
            LoadData();
        }

        #region Encapsulamento
        public MatchDetail MatchDetail { get { return _matchDetail; } set { _matchDetail = value; OnPropertyChanged("MatchDetail"); } }
        public bool StatusVisibleOnGoing { get { return _statusVisibleOnGoing; } set { _statusVisibleOnGoing = value; OnPropertyChanged("StatusVisibleOnGoing"); } }
        public bool StatusVisibleStart { get { return _statusVisibleStart; } set { _statusVisibleStart = value; OnPropertyChanged("StatusVisibleStart"); } }
        #endregion

        #region Commands
        public Command OccurrenceCommand => _occurrenceCommand ?? (_occurrenceCommand = new Command(async () => { await OccurrenceCommandExecute(); }));
        public Command FinishCommand => _finishCommand ?? (_finishCommand = new Command(async () => { await FinishCommandExecute(); }));
        public Command StartCommand => _startCommand ?? (_startCommand = new Command(async () => { await StartCommandExecute(); }));
        #endregion

        #region Funções
        public async Task LoadData()
        {
            try
            {
                MatchService matchService = new MatchService();
                MatchDetail matcheDetail = await matchService.GetMatchesById(_matchId.ToString());
                if (matcheDetail != null)
                {
                    MatchDetail = matcheDetail;
                    StatusVisibleOnGoing = matcheDetail.Status == MatchStatusEnum.OnGoing ? true : false;
                    StatusVisibleStart = matcheDetail.Status == MatchStatusEnum.Created ? true : false;
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", ex.Message, "OK");
            }
        }

        private async Task OccurrenceCommandExecute()
        {
            try
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Funcionalidade ainda em desenvolvimento", "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private async Task FinishCommandExecute()
        {
            try
            {
                string action = await App.Current.MainPage.DisplayActionSheet("Selecione time ganhador:", "Cancel", null, "Time A", "Time B");
                FinishMatch finishMatch = new FinishMatch()
                {
                    IdMatch = MatchDetail.Id,
                    MatchPhase = MatchDetail.PhaseNumber,
                    IdWinner = Guid.Empty
                };
                switch (action)
                {
                    case "Time A":
                        finishMatch.IdWinner = MatchDetail.IdTeamA;
                        break;
                    case "Time B":
                        finishMatch.IdWinner = MatchDetail.IdTeamB;
                        break;
                    case "Cancel":
                        break;
                    default:
                        break;
                }
                MatchService matchService = new MatchService();
                var resp = await matchService.FinishMatch(finishMatch);
                if (resp)
                {
                    await App.Current.MainPage.DisplayAlert("Atenção", "Confronto finalizado!", "OK");
                    await LoadData();
                }
                else
                    await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível finalizar confronto. Tente novamente.", "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private async Task StartCommandExecute()
        {
            try
            {
                MatchService matchService = new MatchService();
                StartMatch startMatch = new StartMatch()
                {
                    IdMatch = MatchDetail.Id
                };
                var resp = await matchService.StartMatch(startMatch);
                if (resp)
                {
                    await App.Current.MainPage.DisplayAlert("Atenção", "Confronto iniciado!", "OK");
                    await LoadData();
                }
                else
                    await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar confronto. Tente novamente.", "OK");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }
        #endregion
    }
}

