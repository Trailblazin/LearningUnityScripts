using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningConstructorTeam : MonoBehaviour {

    public LearningConstructorTeammate seun;
    public LearningConstructorTeammate soraya;


	void Start () {

        //Constructed objects with the properties of player name, role and class type
        seun = new LearningConstructorTeammate("BlazinkidHD", "DPS", "Technoblader");
        soraya = new LearningConstructorTeammate("FenixLady", "Buffer", "Sorcerer");

        //Assignement of teammate property to the objects
        seun.teammate = soraya;
        soraya.teammate = seun;

        //Statements to determine the nature of the teammate property in this context
        if (seun.IsPairedWith(soraya) && soraya.IsPairedWith(seun))
        {
            Debug.Log(seun.playerName + " is paired with " + soraya.playerName);
        }
        else if (seun.IsPairedWith(soraya) && !soraya.IsPairedWith(seun))
        {
            Debug.Log(seun.playerName + " is no longer paired with " + soraya.playerName);
        }
        else
        {
            Debug.Log(seun.playerName + " and " + soraya.playerName + " have yet to find teammates");

        }
    }
	
}
