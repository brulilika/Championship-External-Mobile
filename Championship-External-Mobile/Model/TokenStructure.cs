using System;
namespace ChampionshipExternalMobile.Model
{
	public class TokenStructure
	{
		public string userId { get; set; }
        public double nbf { get; set; }
        public double exp { get; set; }
        public double iat { get; set; }
    }
}

