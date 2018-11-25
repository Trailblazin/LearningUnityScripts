using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningArrayList : MonoBehaviour {

    public ArrayList inventory = new ArrayList();

	void Start ()
    {
        inventory.Add(1);
        inventory.Add(2);
        inventory.Add("Caliburn");
        inventory.Add(GameObject.Find("Player"));


        Debug.Log(inventory[1].GetType());
        Debug.Log(inventory[2].GetType());


    }

    
}
