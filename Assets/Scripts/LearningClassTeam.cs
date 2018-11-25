using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningClassTeam : MonoBehaviour {

    public LearningClassTeammates seun;
    public LearningClassTeammates soraya;

	void Start ()
    {
        seun = new LearningClassTeammates();
        seun.playerName = "BlazinkidHD";
        seun.classType = "Technoblader";
        seun.role = "DPS";

        soraya = new LearningClassTeammates();
        soraya.playerName = "FenixLady";
        soraya.classType = "Sorcerer";
        soraya.role = "Buffer";

        seun.teammate = soraya;
        soraya.teammate = seun;

        if (seun.IsPairedWith(soraya) && soraya.IsPairedWith(seun))
        {
            Debug.Log(seun.playerName + " is paired with " + soraya.playerName);
        }
        else if(seun.IsPairedWith(soraya) && !soraya.IsPairedWith(seun))
        {
            Debug.Log(seun.playerName + " is no longer paired with " + soraya.playerName);
        }
        else
        {
            Debug.Log(seun.playerName + " and " + soraya.playerName + " have yet to find teammates");

        }


    }
	
}
