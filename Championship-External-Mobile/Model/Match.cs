using System;
namespace ChampionshipExternalMobile.Model
{
	public class Match
	{
		public string TeamA { get; set; }
        public string TeamB { get; set; }
        public string Status { get; set; }
        public MatchStatusEnum StartDate { get; set; }
    }
}

