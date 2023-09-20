using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnClick : MonoBehaviour
{
    public string sceneToLoad = "Scene 1";

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Collider2D collider = GetComponent<Collider2D>();
            if (collider != null && collider.OverlapPoint(mousePosition))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
