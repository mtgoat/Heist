using System;
using System.Collections.Generic;
using System.Linq;
namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            
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
            //   empty list to fill with myTeam using TeamMember  

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

            while(true){
                Console.WriteLine("What is a name of the new person to add to the roladex?");

            string personName = Console.ReadLine();

            if(personName == ""){
                    break;
                }

            Console.WriteLine($"You typed {personName} as a name.");

            Console.WriteLine(@"Next, please select a specialist type from the following.
            Hacker (Disables alarms): enter 1
            Muscle (Disarms guards): enter 2
            Lock Specialist (cracks vault): enter 3.");

            string specialist = Console.ReadLine();

            // this if needs to be refactored. 
            if(specialist =="1"){
                Hacker newMember = new Hacker(){
                    name = personName
                };

                add(newMember);
                
            }
            else if (specialist =="2"){
                Muscle newMember = new Muscle(){
                    name = personName
                };
               
                add(newMember);

            }else if (specialist =="3"){
                LockSpecialist newMember = new LockSpecialist(){
                    name = personName
                };

                add(newMember);

            }else{
                Console.WriteLine("please enter a number from 1 to 3.");
            }

            }
//function to add a newMember to myRolodex list
        void add (IRobber newMember){
            //add skill ,
        Console.WriteLine("What is a the new person's skill level? please enter between 0 to 100.");

        int personSkill = int.Parse(Console.ReadLine());

        Console.WriteLine($"You typed {personSkill} as a skill level.");

        newMember.skillLevel = personSkill;
       

        //add cut ,
        Console.WriteLine("What is a the new person's cut? please enter between 0 to 100.");

        int personCut = int.Parse(Console.ReadLine());

        Console.WriteLine($"You typed {personCut} as a skill level.");

        myRolodex.Add(newMember);

        Console.WriteLine($"Currently we have {myRolodex.Count} operatives in the roladex.");


        };
            
        //create a new bank object

            Bank BankOfAmericas = new Bank (){
                cashOnHand = new Random().Next(50000, 1000000),
                alarmScore = 6,
                vaultScore = 100,
                securityGuardScore = 0,
            };
            // new Random().Next(0, 100),

  Dictionary <string, int> DictionaryBoA = new Dictionary <string, int> (){
                {"alarmScore", BankOfAmericas.alarmScore},
                {"vaultScore", BankOfAmericas.vaultScore},
                {"securityGuardScore", BankOfAmericas.securityGuardScore},
            };

string keyOfMaxValue = DictionaryBoA.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
string keyOfMinValue = DictionaryBoA.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;

Console.WriteLine($"Most Secure: {keyOfMaxValue}");
Console.WriteLine($"Least Secure: {keyOfMinValue}");

// Print out a report of the rolodex that includes each person's name, specialty, skill level, and cut. Include an index in the report for each operative so that the user can select them by that index in the next step.
Report myRolodexReport = new Report ();


//this is to print out persons in myRoledex with i in a hard way.  At the end of each print, adding the person in myRolodex to the RolodexReport

     Console.WriteLine("----------------- -----------");
     Console.WriteLine("------myRolodex report-------");
     int reportIndex = 1; 
 foreach(IRobber person in myRolodex){

     myRolodexReport.AddContact(reportIndex, person);


     Console.WriteLine("----------------------------");
     Console.WriteLine($"Id: {reportIndex}");
     Console.WriteLine($"Name: {person.name}");
     Console.WriteLine($"Speciality: {person.speciality}");
     Console.WriteLine($"Skill Level: {person.skillLevel}");
     Console.WriteLine($"Cut: {person.percentageCut}");
     Console.WriteLine();
    
    reportIndex += 1;
}      

Console.WriteLine("------End of myRolodex report -------");

List<IRobber> crew = new List<IRobber>();

Console.WriteLine("Please select a person to add to the Heist team by the index in the report");
while(true){
int indexToAdd = int.Parse(Console.ReadLine());

//in the myRolodexReport, using the GetByIndex method to get a const by its index and adding the contact to the crew list
crew.Add(myRolodexReport.GetByIndex(indexToAdd));

Console.WriteLine($"You have added {myRolodexReport.GetByIndex(indexToAdd)} to the crew.");

//printing the report after being added to the crew list

 Console.WriteLine("----------------- --------");
 Console.WriteLine("------myCrew report-------");
//how to get a total number of objects in the myRolodex dictionary?
for (int i =1; i < myRolodex.Count; i++ ){

// }

// foreach ( KeyValuePair <int, IRobber> person in myRolodexReport){
//     Console.WriteLine($"ID ={person.name}");
// } This cause an error message for not having getEnumorator
}

// Console.WriteLine("print the highst", result);
//              Console.WriteLine("Most Secure: Alarm Least Secure: Vault");
//  } 
 
              





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
