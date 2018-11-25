using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsWhile : MonoBehaviour {

    public List<string> familyMembers = new List<string>();

    // Use this for initialization
    void Start ()
    {
        familyMembers.Add("Seun");
        familyMembers.Add("Bibi");
        familyMembers.Add("Femi");
        familyMembers.Add("Lekan");

        int i = 0;

      /*Another way to iterate through an array/list; 
        better used to hold code execution under a given condition*/

        while (i < familyMembers.Count)
        {
            Debug.Log(familyMembers[i]);
            i++;
        }
    }
	

}
