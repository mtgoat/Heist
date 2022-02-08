using System;
using System.Collections.Generic;

namespace heist
{

    public class Muscle : IRobber
    {
        public string name { get; set ; }
        public int skillLevel { get ; set ; }
        public int percentageCut { get ; set ; }

        public string speciality { 
            get { 
                    return "Muscle";
            }
        }

        void PerformSkill (Bank bankObj)
        {   
               //skillLevel to Bank.AlarmScore
          int score = bankObj.securityGuardScore - skillLevel;
            Console.WriteLine($"Mr. {name} is working on the security guard. Decreased security 50 points.");

            if (score <=0 ){
                Console.WriteLine($"Mr {name} has disabled the alarm system!"); 
            }else {
                Console.WriteLine($"I'm sorry to inform you that we could not get through the security guard.");
            }
     
     
     }
    
    
    
    
    
    
    
    }
}