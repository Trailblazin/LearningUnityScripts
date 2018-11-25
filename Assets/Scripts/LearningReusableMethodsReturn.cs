using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningReusableMethodsReturn : MonoBehaviour {


    public int number1 = 2;
    public int number2 = 3;

	// Use this for initialization
	void Start ()
    {
        int sumResult = AddTwoNumbers(number1, number2);

        DisplayResult(sumResult);
    }

    int AddTwoNumbers (int firstNumber, int secondNumber)
    {
        int result = firstNumber + secondNumber;
        return result;
    }


    void DisplayResult (int total)
    {
        Debug.Log("The grand total is:" + total);
    }
}
