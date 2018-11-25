using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHashTable : MonoBehaviour {

    /*Hashtables are un-typed; you may use two key-value pairs of any datatype
    Attempting to retreive from an index in which an item is not present will return an null value*/
    public Hashtable personalDetails = new Hashtable();


	void Start ()
    {
        personalDetails.Add("Name", "Seun");
        personalDetails.Add("Surname", "Osikomaiya");
        personalDetails.Add("Class", "TecnoMeister");
        personalDetails.Add("isActive", true);
        personalDetails.Add("Rank", 1);
        

        if (personalDetails.Contains("Class"))
        {
            Debug.Log((string)personalDetails["Class"]);
        }
        else
        {
            Debug.Log("No class item in hashtable");
        }

    }
	
}
