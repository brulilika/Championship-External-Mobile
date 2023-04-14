using System;
using System.Threading.Tasks;
using Championship_External_Mobile;
using ChampionshipExternalMobile.View;
using Xamarin.Forms;
using ChampionshipExternalMobile.Service;
using ChampionshipExternalMobile.Model.Request;
using Xamarin.Essentials;
using System.Collections.Generic;
using ChampionshipExternalMobile.Model;

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
        public Command ButtonCommand => _buttonCommand ?? (_buttonCommand = new Command( async () => { await LoginCommandExecute(); }));
        #endregion

        #region Funções
        private async Task LoginCommandExecute()
        {
            try
            {
                if (InputValidation())
                {
                    var loginService = new LoginService();
                    if (await loginService.Login(new LoginRequest() { email = Username, password = Password }))
                    {
                        App.Current.MainPage = new NavigationPage(new MainPage());
                    }
                    else
                        await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível fazer o login. Verifique usuário e senha informado.", "Ok");
                }                
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", ex.Message, "Ok");
            }
        }

        private bool InputValidation()
        {
            try
            {
                if (String.IsNullOrEmpty(Username))
                    throw new Exception("É obrigatório informar email");
                if(String.IsNullOrEmpty(Password))
                    throw new Exception("É obrigatório informar senha");

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}

