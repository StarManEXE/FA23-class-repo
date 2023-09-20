using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    // Adjust this value to control the object's speed.
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in world coordinates.
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Make sure the object stays at the same Z position.
        mousePosition.z = 0f;

        // Move the object towards the mouse position smoothly.
        transform.position = Vector3.Lerp(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
