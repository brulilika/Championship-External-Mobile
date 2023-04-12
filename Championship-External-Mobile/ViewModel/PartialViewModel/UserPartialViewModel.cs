using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship_External_Mobile;
using ChampionshipExternalMobile.Model;

namespace ChampionshipExternalMobile.ViewModel.PartialViewModel
{
    public class UserPartialViewModel : BaseViewModel
    {
        #region Propriedades
        private List<UserFunctions> _userFunctions;
        #endregion

        public UserPartialViewModel()
        {
            UserFunctions = new List<UserFunctions>();
            LoadData();
        }

        #region Encapsulamento
        public List<UserFunctions> UserFunctions { get { return _userFunctions; } set { _userFunctions = value; OnPropertyChanged("UserFunctions"); } }
        #endregion

        #region Commands
        #endregion

        #region Funções
        public async Task LoadData()
        {
            try
            {
                UserFunctions.Add(new UserFunctions() { Title= "Teste1", Redirect=""});
                UserFunctions.Add(new UserFunctions() { Title = "Teste2", Redirect = "" });
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }
        #endregion
    }
}

