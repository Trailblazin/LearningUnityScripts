using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningLists : MonoBehaviour {

    public List<string> familyMembers = new List<string>();

	void Start ()
    {
        familyMembers.Add("Seun");
        familyMembers.Add("Bibi");
        familyMembers.Add("Femi");
        familyMembers.Add("Lekan");



        string thirdFamilyMember = familyMembers[2];
        Debug.Log(thirdFamilyMember);

    }
	

}
