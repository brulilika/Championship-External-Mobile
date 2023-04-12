using System;
using ChampionshipExternalMobile.View;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.ViewModel
{
	public class LoginPageViewModel : BaseViewModel
    {
        #region Propriedades
        private INavigation _navigation;
        private string _username;
        private string _password;
        private Command _buttonCommand;
        #endregion

        public LoginPageViewModel(INavigation navigation)
		{
            _navigation = navigation;
		}

        #region Encapsulamento
        public string Username { get { return _username; } set { _username = value; OnPropertyChanged("Username"); } }
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged("Password"); } }
        #endregion

        #region Commands
        public Command ButtonCommand => _buttonCommand ?? (_buttonCommand = new Command( () => {

            try
            {
                Championship_External_Mobile.App.Current.MainPage = new NavigationPage(new MainPage()); 
            }
            catch
            {

            }
        }));
        #endregion

        #region Funções
        #endregion
    }
}

