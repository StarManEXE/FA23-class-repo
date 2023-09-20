using System.Collections;
using UnityEngine;
using System.Collections.Generic;

public class SuperHover2 : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // The original sprite of the object.
    private Sprite originalSprite;

    // The sprite to use when the cursor is hovering over other objects.
    public Sprite hoverSprite;

    // Start is called before the first frame update.
    void Start()
    {
        // Get the SpriteRenderer component attached to this object.
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Store the original sprite.
        originalSprite = spriteRenderer.sprite;
    }

    // Update is called once per frame.
    void Update()
    {
        // Cast a ray from the mouse cursor into the scene.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

        // Check if the ray hits any objects.
        if (hit.collider != null)
        {
            // Check if the hit object is the current GameObject.
            if (hit.collider.gameObject == gameObject)
            {
                // Change the sprite to the hoverSprite when hovering.
                spriteRenderer.sprite = hoverSprite;
            }
            else
            {
                // Revert to the original sprite when not hovering.
                spriteRenderer.sprite = originalSprite;
            }
        }
        else
        {
            // Revert to the original sprite when not hovering.
            spriteRenderer.sprite = originalSprite;
        }
    }
}
