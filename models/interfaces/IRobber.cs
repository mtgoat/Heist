using System.Collections.Generic;
//at the interface, we do not use public for property and method 
namespace heist
{
public interface IRobber {

     string name {get; set;}

     int skillLevel {get; set;}

     int percentageCut {get; set;}
     void PerformSkill (Bank bankObj)
     {
               // to be defined at a class file
     }

     string speciality {get;}
}
}