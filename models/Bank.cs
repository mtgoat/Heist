using System;
using System.Collections.Generic;

namespace heist
{
     public class Bank
    {
    public int cashOnHand {get; set;}

    public int alarmScore {get; set;}

    public int vaultScore {get; set;}

    public int securityGuardScore {get; set;}

    public bool isSecure {get; set;}

    public bool GotIsSecure (){

        bool GotIsSecure = ((cashOnHand * alarmScore * vaultScore * securityGuardScore) > 0)? true: false;
        return GotIsSecure;
    }
    // step 2: if two negatives?

    
    
        
    

     
    
     
    }
    }












