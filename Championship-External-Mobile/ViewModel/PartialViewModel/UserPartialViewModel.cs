using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Championship_External_Mobile;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.View;
using ChampionshipExternalMobile.Service;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace ChampionshipExternalMobile.ViewModel.PartialViewModel
{
    public class UserPartialViewModel : BaseViewModel
    {
        #region Propriedades
        private List<UserFunctions> _userFunctions;
        private string _userName;
        private string _email;
        #endregion

        public UserPartialViewModel()
        {
            UserFunctions = new List<UserFunctions>();
            UserName = "Não identificado";
            LoadData();
        }

        #region Encapsulamento
        public List<UserFunctions> UserFunctions { get { return _userFunctions; } set { _userFunctions = value; OnPropertyChanged("UserFunctions"); } }
        public string UserName { get { return _userName; } set { _userName = value; OnPropertyChanged("UserName"); } }
        public string Email { get { return _email; } set { _email = value; OnPropertyChanged("Email"); } }
        #endregion

        #region Commands
        #endregion

        #region Funções
        public async Task LoadData()
        {
            try
            {
                UserFunctions.Add(new UserFunctions() { Title = "Editar usuário", Redirect = "Edit" });
                UserFunctions.Add(new UserFunctions() { Title = "Logout", Redirect = "Logout" });

                LoginService loginService = new LoginService();
                string userId = Preferences.Get("userId","");
                User user = await loginService.GetUserById(userId);
                if (user != null)
                {
                    UserName = user.name;
                    Email = user.email;
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível iniciar lista de funções do cliente", "OK");
            }
        }

        public async Task UserFunctionCommands(UserFunctions redirect)
        {
            try
            {
                switch (redirect.Redirect)
                {
                    case "Edit":
                        await App.Current.MainPage.DisplayAlert("Atenção", "Funcionalidade ainda em desenvolvimento", "OK");
                        break;
                    case "Logout":

                        App.Current.MainPage = new NavigationPage(new LoginPage());
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Atenção", "Não foi possível executar a função necessária", "OK");
            }
        }
        #endregion
    }
}

