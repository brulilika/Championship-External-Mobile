using System;
using Xamarin.Forms;

namespace ChampionshipExternalMobile.ViewModel
{
	public class InitialBoardViewModel : BaseViewModel
    {
        #region Propriedades
        private string _username;
        private string _password;
        private Command _buttonCommand;
        #endregion

        public InitialBoardViewModel()
		{
		}

        #region Encapsulamento
        public string Username { get { return _username; } set { _username = value; OnPropertyChanged("Username"); } }
        public string Password { get { return _password; } set { _password = value; OnPropertyChanged("Password"); } }
        #endregion

        #region Commands
        public Command ButtonCommand => _buttonCommand ?? (_buttonCommand = new Command(async () => {

            try
            {
                Console.WriteLine(Username +" "+ Password);

            }
            catch
            {

            }
            finally
            {

            }
        }));
        #endregion

        #region Funções
        #endregion
    }
}