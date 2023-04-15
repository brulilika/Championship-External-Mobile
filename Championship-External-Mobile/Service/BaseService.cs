using System;
namespace ChampionshipExternalMobile.Service
{
	public class BaseService
	{
        public string URL { get; set; }

        public BaseService()
        {
            URL = "http://192.168.0.13:7232/";
            //URL = "https://champscoreapi.azurewebsites.net/";
        }
    }
}

