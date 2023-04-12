using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship_External_Mobile;

namespace ChampionshipExternalMobile.ViewModel.PartialViewModel
{
    public class UserPartialViewModel : BaseViewModel
    {
        #region Propriedades
        private List<string> _userFunctions;
        #endregion

        public UserPartialViewModel()
        {
            UserFunctions = new List<string>();
            LoadData();
        }

        #region Encapsulamento
        public List<string> UserFunctions { get { return _userFunctions; } set { _userFunctions = value; OnPropertyChanged("UserFunctions"); } }
        #endregion

        #region Commands
        #endregion

        #region Funções
        public async Task LoadData()
        {
            try
            {
                UserFunctions.Add("Teste1");
                UserFunctions.Add("Teste2");
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }
        #endregion
    }
}

