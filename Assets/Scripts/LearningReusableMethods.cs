using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningReusableMethods : MonoBehaviour {

    public int numero1 = 3;
    public int numero2 = 7;
    public int numero3 = 8;

    // Use this for initialization
    void Start ()
    {
        AddAndPrintNumberPair(numero1, numero2);
        AddAndPrintNumberPair(numero1, numero3);
        AddAndPrintNumberPair(numero2, numero3);
        

    }


    void AddAndPrintNumberPair(int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        Debug.Log(result);
    }
}
