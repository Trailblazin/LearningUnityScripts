using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsSearching : MonoBehaviour {

    public List<string> familyMembers = new List<string>();

    void Start ()
    {
        familyMembers.Add("Seun");
        familyMembers.Add("Bibi");
        familyMembers.Add("Femi");
        familyMembers.Add("Lekan");

        //-1 was chosen for no particular reason, any assignable value for lekanIndex will work here
        int lekanIndex = -1;

        for( int i = 0; i < familyMembers.Count; i++)
        {
            if (familyMembers[i] == "Lekan")
            {
                lekanIndex = i;
                //The break statement is added as a performance measure to prevent further loop iteration
                break;
            }
        }

        //If this statement is true, that means the above for statement didnt assign an index value to lekanIndex
        if (lekanIndex == -1)
        {
            Debug.Log("The value Lekan is not stored in the list.");
        }
        else
        {
            Debug.Log("Lekan was found at index " + lekanIndex);
        }

    }
	
}
