using System;
using System.Collections.Generic;

namespace heist {
    
    public class TeamList
    {
        List<TeamMember> myTeam{get; set;} = new List <TeamMember>();

        public void addMember(TeamMember person)
        {
            myTeam.Add(person);
        }

    }

}