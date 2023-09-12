using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text numberText; // Reference to the UI Text element on the Canvas
    private int variableNumber = 42; // Replace with your variable

    // Update is called once per frame
    void Update()
    {
        // Update the displayed text with the variable number
        numberText.text = "Variable Number: " + variableNumber.ToString();
    }
}
