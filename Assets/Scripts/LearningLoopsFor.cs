using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsFor : MonoBehaviour {

    public List<string> familyMembers = new List<string>();

    void Start ()
    {
        familyMembers.Add("Seun");
        familyMembers.Add("Bibi");
        familyMembers.Add("Femi");
        familyMembers.Add("Lekan");

        //Best way to iterate through an array/list
        for (int i = 0; i < familyMembers.Count; i++)
        {
            Debug.Log(familyMembers[i]);
        }

    }
	
}
