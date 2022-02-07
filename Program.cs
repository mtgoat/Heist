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
            
            Hacker Aaron = new Hacker (){
                name = "Aaron",
                skillLevel = 75,
                percentageCut = 20
            };

            Hacker Andrea = new Hacker (){
                name = "Andrea",
                skillLevel = 75,
                percentageCut = 25
            };

            Muscle Alice = new Muscle(){
                name = "Alice",
                skillLevel = 70,
                percentageCut = 20
            };

            LockSpecialist Ace = new LockSpecialist(){
                 name = "Ace",
                skillLevel = 50,
                percentageCut = 20
            } ;

            LockSpecialist Addy = new LockSpecialist(){
                name = "Addy",
                skillLevel = 45,
                percentageCut = 10
            } ;

            List<TeamMember> myTeam = new List<TeamMember>();

            //const(List<teamMember>) list(myTeam) = [] (new List<teamMember>();)

            //pre-populate the list with 5 or 6 robbers
            List<IRobber> myRolodex = new List<IRobber>(){
                Addy,
                Ace,
                Alice,
                Andrea,
                Aaron
            };

            Console.WriteLine($"Currently we have {myRolodex.Count} operatives in the roladex.");

            Console.WriteLine("Let's add new person to the roladex!");



            Console.WriteLine("What is a name of the new person to add to the roladex?");

            string personName = Console.ReadLine();

            Console.WriteLine($"You typed {personName} as a name.");

            Console.WriteLine(@"Next, please select a specialist type from the following.
            Hacker (Disables alarms): enter 1
            Muscle (Disarms guards): enter 2
            Lock Specialist (cracks vault): enter 3.");

            string specialist = Console.ReadLine();
            
            if(specialist =="1"){
                Hacker newHacker = new Hacker(){
                    name = personName
                };
                myRolodex.Add(newHacker);
                Console.WriteLine(newHacker.name);
            }
            else if (specialist =="2"){
                Muscle newMuscle = new Muscle(){
                    name = personName
                };
                myRolodex.Add(newMuscle);
                
            }else if (specialist =="3"){
                LockSpecialist newLock = new LockSpecialist(){
                    name = personName
                };
                myRolodex.Add(newLock);
            }else{
                Console.WriteLine("please enter a number from 1 to 3.");
            }


            // switch (specialist){
            //     case "1":
            //     //function to add a new member to a hacker
            //     break;
            //     case "2":
            //     string occupation = "Muscle";
            //     break;
            // }

            

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
            TeamMember newMember = new TeamMember ();// const newMember = {}

            newMember.createTeamMember(name, skillLevel, courageFactor);

            //  Console.WriteLine(newMember.name);

             myTeam.Add(newMember);
            }
            
             Console.WriteLine($"Good job! You built your team! There are {myTeam.Count} members on your team!");

           Console.WriteLine($"Would you like to try trials to run? Please enter a number.");
          int trials = int.Parse(Console.ReadLine());
 
        int teamSkillLevel = 0;

            foreach(TeamMember member in myTeam){
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
