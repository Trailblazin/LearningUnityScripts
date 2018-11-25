using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLoopsForeach : MonoBehaviour {

    public List<string> familyMembers = new List<string>();
    // Use this for initialization
    void Start ()
    {
        familyMembers.Add("Seun");
        familyMembers.Add("Bibi");
        familyMembers.Add("Femi");
        familyMembers.Add("Lekan");

        foreach (string familyMember in familyMembers)
        {
            Debug.Log(familyMember);
        }
    }


}
