using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningClassParty : MonoBehaviour {


    public LearningClassPerson seun;
    public LearningClassPerson evan;
    public LearningClassPerson noah;
    public LearningClassPerson soraya;

    void Start ()
    {
        seun = new LearningClassPerson();
        seun.firstName = "Seun";
        seun.age = 19;
        seun.isArisen = true;
        seun.classType = "Assassin";

        evan = new LearningClassPerson();
        evan.firstName = "Evan";
        evan.age = 19;
        evan.isArisen = false;
        evan.classType = "Sharpshooter";

        noah = new LearningClassPerson();
        noah.firstName = "Noah";
        noah.age = 20;
        noah.isArisen = true;
        noah.classType = "Ranger";

        soraya = new LearningClassPerson();
        soraya.firstName = "Soraya";
        soraya.age = 19;
        soraya.isArisen = false;
        soraya.classType = "Sorcerer";


    }
}
