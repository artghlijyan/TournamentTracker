using System.Collections.Generic;

namespace TrackerLib.Models
{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; }
        public string TeamName { get; set; }

        public TeamModel()
        {
            TeamMembers = new List<PersonModel>();
        }

    }
}
