using System.Collections.Generic;

namespace TrackerLib.Models
{
    public class TournamentModel
    {
        public string TournamentName { get; set; }
        public decimal EntryFee{ get; set; }
        public List<TeamModel> EnteredTeams { get; set; }
        public List<PrizeModel> Prizes { get; set; }
        public List<MatchupModel> Rounds { get; set; }

        public TournamentModel()
        {
            EnteredTeams = new List<TeamModel>();
            Prizes = new List<PrizeModel>();
            Rounds = new List<MatchupModel>();
        }
    }
}
