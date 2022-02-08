using System;
using System.Collections.Generic;
using System.Linq;
// Print out a report of the rolodex that includes each person's name, specialty, skill level, and cut. Include an index in the report for each operative so that the user can select them by that index in the next step.

namespace heist
{

    public class Report
    {
        //this creates a dictionary object named _contactList and inside, it has index as a type of key and Contact object as a value
            public Dictionary<int, IRobber> contactList {get; set;} = new Dictionary<int, IRobber>();

            public void AddContact(int index, IRobber personObj)
            {
                contactList.Add(index, personObj);
            }

            public IRobber GetByIndex(int index)
            {
                return contactList[index];
            }


    } 
}