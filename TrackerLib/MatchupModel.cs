using System.Collections.Generic;

namespace TrackerLib
{
    public class MatchupModel
    {
        public List<MatchupEntryModel> Entries { get; set; }

        public TeamModel Winner { get; set; }
        public int MathcupRound { get; set; }

        public MatchupModel()
        {
            Entries = new List<MatchupEntryModel>();
        }
    }
}