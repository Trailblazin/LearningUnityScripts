using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningClassTeammates{

    public string playerName = "";
    public string role = ""; 
    public string classType = "";
    public LearningClassTeammates teammate;

    public bool IsPairedWith (LearningClassTeammates partner)
    {
        //Condition to check that a Teammate is stored in the variable partner
        if (teammate != null)
        {
            //Statement to check that the passed partner variable is thhe same as the stored teammate
            if (partner == this.teammate)
            {
                return true;
            }

            //If the teammate is in a team with another player
            else
            {
                return false;
            }
        }
        //If the teammate variable has an unassigned value
        //The player is unmatched with no teammate
        else
        {
            return false;
        }

    }


}
