using System;
using System.Collections.Generic;

namespace heist
{
     public class teamMember
    {
            public string name {get; set;}
            public int skillLevel {get; set;}

            public double courageFactor {get; set;}

        public void createTeamMember(string nameInput, int skillLevelInput, double courageFactorInput)
        {
                name = nameInput;
                skillLevel = skillLevelInput;
                courageFactor = courageFactorInput;
        }



    }
}