using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningMoreStatements : MonoBehaviour {

	void Start ()
    {
        int speedLimit = 60;

        if (speedLimit == 70)
        {
            Debug.Log("Let's Rev it up, we're on the motorway!");
        }

        else if (speedLimit < 70 && speedLimit >= 30)
        {
            Debug.Log("Average Carridgeway speed limits, lets keep it focused.");
        }

        else
        {
            Debug.Log("We're on a main road, lets be careful.");
        }
	}
}
