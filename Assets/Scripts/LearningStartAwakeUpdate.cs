using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningStartAwakeUpdate : MonoBehaviour {

    // Use this for frame 1 initialization
    void Awake()
    {
        Debug.Log("Awake function has been called");
    }
    // Use this for initialization
    void Start ()
    {
        Debug.Log("Start function has been called");
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log("Update function has been called");
    }
}
