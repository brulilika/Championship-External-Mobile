using System;
namespace ChampionshipExternalMobile.Model
{
	public class Match
	{
        public string MatchCode { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public string CompetitionCode { get; set; }
        public MatchStatusEnum Status { get; set; }
        public string StartDate { get; set; }
    }
}

