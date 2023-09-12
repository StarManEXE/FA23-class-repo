using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score1Value = 1; // Score value to increase when contact is made
    public int score3Value = 3; // Score value to increase when contact is made
    public int score10Value = 10; // Score value to increase when contact is made
    public int score100Value = 100; // Score value to increase when contact is made
    public int score1000Value = 1000; // Score value to increase when contact is made

    public TextMeshProUGUI numberText; // Reference to the UI Text element on the Canvas

    public Transform teleportDestination; // Destination where the object will be teleported

    public int currentScore = 0; // Current score

    public void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "score" tag
        if (other.CompareTag("score1"))
        {
            // Increment the score
            currentScore += score1Value;

            transform.position = new Vector3(9.18999958f, -6.03000021f, 4.26999998f);

          /*  // Teleport the object to the specified destination
            if (teleportDestination != null)
            {
                transform.position = teleportDestination.position;
            }*/
        }

        // Check if the colliding object has the "score" tag
        if (other.CompareTag("score3"))
        {
            // Increment the score
            currentScore += score3Value;
            gameObject.transform.position = new Vector3(9.18999958f, -6.03000021f, 4.26999998f);

            // Teleport the object to the specified destination
            /*if (teleportDestination != null)
            {
                transform.position = teleportDestination.position;
            }*/
        }

        // Check if the colliding object has the "score" tag
        if (other.CompareTag("score10"))
        {
            // Increment the score
            currentScore += score10Value;
            gameObject.transform.position = new Vector3(9.18999958f, -6.03000021f, 4.26999998f);

            /* // Teleport the object to the specified destination
             if (teleportDestination != null)
             {
                 transform.position = teleportDestination.position;
             }*/
        }

        // Check if the colliding object has the "score" tag
        if (other.CompareTag("score100"))
        {
            // Increment the score
            currentScore += score100Value;
            transform.position = teleportDestination.position;

           /* // Teleport the object to the specified destination
            if (teleportDestination != null)
            {
                transform.position = teleportDestination.position;
            }*/
        }

        // Check if the colliding object has the "score" tag
        if (other.CompareTag("score1000"))
        {
            // Increment the score
            currentScore += score1000Value;
            transform.position = teleportDestination.position;

           /* // Teleport the object to the specified destination
            if (teleportDestination != null)
            {
                transform.position = teleportDestination.position;
            }*/
        }
    }
    void Update()
    {
        // Update the displayed text with the variable number
        numberText.text = "Wins: " + currentScore.ToString();
    }
}
