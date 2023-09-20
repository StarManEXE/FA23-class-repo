using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarTalk : MonoBehaviour
{
    // The name of the scene you want to load when the sprite is clicked.
    public string sceneToLoad = "TalkStar";

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in world coordinates.
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if the mouse click is over the sprite's collider.
            Collider2D collider = GetComponent<Collider2D>();
            if (collider != null && collider.OverlapPoint(mousePosition))
            {
                // Load the specified scene.
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
