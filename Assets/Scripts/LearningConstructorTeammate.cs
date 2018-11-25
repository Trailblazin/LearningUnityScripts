using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningConstructorTeammate {

    public string playerName = "";
    public string role = "";
    public string classType = "";
    public LearningConstructorTeammate teammate;

    public LearningConstructorTeammate()
    {

    }

    public LearningConstructorTeammate(string pPlayerName, string pRole, string pClassType)
    {
        this.playerName = pPlayerName;
        this.role = pRole;
        this.classType = pClassType;

    }

    public bool IsPairedWith(LearningConstructorTeammate partner)
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
