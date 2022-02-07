using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            //   empty list to fill with myTeam using TeamMember  
            List<teamMember> myTeam = new List<teamMember>();

            //const(List<teamMember>) list(myTeam) = [] (new List<teamMember>();)


            Console.WriteLine("What is the bank difficulty?");
            int bankDifficulty = int.Parse(Console.ReadLine());

            // for (int i=0;i==i;i++){
            while(true){
                //using loop to reiterate questions so we can get multiple team members
                // i++;
                Console.WriteLine($"Enter team member number {myTeam.Count}'s name?");
            string name = Console.ReadLine ();
            if(name == ""){
                    break;
                }
                                // this breaks the loop if no name is entered so you can get total team # and skills to run trials

            Console.WriteLine($"What is the member{myTeam.Count}'s skill level?");    
            int  skillLevel = int.Parse(Console.ReadLine ());

            Console.WriteLine($"What is the member{myTeam.Count}'s courage factor from 0.0 to 2.0?");

            double courageFactor = double.Parse(Console.ReadLine ());
            
            Console.WriteLine($"Hello {name}!  Your skill level is {skillLevel} and your courage factor is {courageFactor}.");
            
            // teamMember ben;
            // teamMember ben = new teamMember();
            //ben.name = "ben"
            
                //This instantiate a newMember so we can create a team.    We have to instantiate a instance to add it to createTeamMember
                //if we do not have newMember then we can't  create team. 
            teamMember newMember = new teamMember ();// const newMember = {}

            newMember.createTeamMember(name, skillLevel, courageFactor);

            //  Console.WriteLine(newMember.name);

             myTeam.Add(newMember);
            }
            
             Console.WriteLine($"Good job! You built your team! There are {myTeam.Count} members on your team!");

           Console.WriteLine($"Would you like to try trials to run? Please enter a number.");
          int trials = int.Parse(Console.ReadLine());
 
        int teamSkillLevel = 0;

            foreach(teamMember member in myTeam){
                teamSkillLevel += member.skillLevel;
            };

            int badTrials =0;
            int goodTrials =0;

            for(int i=0; i<trials; i++){
           
            int luck = new Random().Next(-10, 10);
            int bankTotalDifficulty = bankDifficulty + luck;

            Console.WriteLine($"");
            Console.WriteLine($"The team's skill level is {teamSkillLevel}");
            Console.WriteLine($"The bank's difficulty level is {bankTotalDifficulty}");

            if (teamSkillLevel > bankTotalDifficulty){
                Console.WriteLine("You are right on the money!");
                goodTrials += 1;
            } else {
                Console.WriteLine ("Try again after horning your skills!");
                badTrials += 1;
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            }

            Console.WriteLine($"Your team succeeded in {goodTrials} times!");
            Console.WriteLine($"Your team failed in {badTrials} times!");
            //to display team member info
            // foreach(teamMember teamMember in myTeam){
            //     Console.WriteLine(teamMember.name);
            //     Console.WriteLine(teamMember.skillLevel);
            //     Console.WriteLine(teamMember.courageFactor);
            //     }  

            // // var myTeam = new Program();
           
            
            // Console.WriteLine();

        }
    }
}
