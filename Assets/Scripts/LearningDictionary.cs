using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningDictionary : MonoBehaviour {

    /*Unlike Hashtables, Dictionaries are types' you can only use key-value pairs of a defined datatype
     Attempting to retrieve a non-existent item from a Dictionary will cause an exception to be thrown. */ 

    public Dictionary<int, string> Inventory = new Dictionary<int, string>();

	
	void Start ()
    {
        Inventory.Add(1, "Technoblade");
        Inventory.Add(2, "Hexal Bracers");
        Inventory.Add(3, "Raikiri's Tabi");
        Inventory.Add(4, "Lucky Candy");

        if(Inventory.ContainsValue("Lucky Candy"))
        {
            Debug.Log("You have a Lucky Candy!");
        }
		
	}

}
