using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningStatements : MonoBehaviour {

    public bool willItBeRainingToday = true;

	void Start ()
    {
        if (willItBeRainingToday)
        {
            Debug.Log("You'll need an umbrella");
        }
        else
        {
            Debug.Log("You'll be fine without an umbrella bro!");
        }

    }
}
