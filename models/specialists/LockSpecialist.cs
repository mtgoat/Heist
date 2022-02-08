using System;
using System.Collections.Generic;

namespace heist
{

    public class LockSpecialist : IRobber
    {
        public string name { get; set ; }
        public int skillLevel { get ; set ; }
        public int percentageCut { get ; set ; }
        public string speciality { 
            get {
                return "LockSpecialist";
            } 
        }

        void PerformSkill (Bank bankObj)
     {   
               //skillLevel to Bank.AlarmScore
               int score = bankObj.vaultScore - skillLevel;
            Console.WriteLine($"Mr. {name} is unlocking the vault. Decreased security {skillLevel} points.");

            if (score <=0 ){
                Console.WriteLine($"Mr {name} has disabled the alarm system!"); 
            }else {
                Console.WriteLine($"I'm sorry to inform you that we could not unlock the vault at this time.");
            }
     }



    }



}