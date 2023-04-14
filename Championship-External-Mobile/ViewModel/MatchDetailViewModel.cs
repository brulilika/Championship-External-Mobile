using System;
using ChampionshipExternalMobile.Model;
using Championship_External_Mobile;
using System.Threading.Tasks;
using Xamarin.Forms;
using ChampionshipExternalMobile.View;

namespace ChampionshipExternalMobile.ViewModel
{
	public class MatchDetailViewModel : BaseViewModel
	{
        #region Propriedades
        #endregion

        public MatchDetailViewModel( Match _match)
		{
            Console.WriteLine(_match.MatchCode);
		}

        #region Encapsulamento
        #endregion

        #region Commands
        #endregion

        #region Funções
        
        #endregion
    }
}

