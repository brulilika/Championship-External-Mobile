using System;
namespace ChampionshipExternalMobile.Model.Request
{
	public class FinishMatch
	{
        public Guid IdMatch { get; set; }
        public Guid IdWinner { get; set; }
        public int MatchPhase { get; set; }
    }
}

