using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorInteract : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;


    public Sprite newSprite;


    private Sprite originalSprite;


    void Start()
    {
 
        spriteRenderer = GetComponent<SpriteRenderer>();

        originalSprite = spriteRenderer.sprite;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<BoxCollider2D>() != null)
        {
            spriteRenderer.sprite = newSprite;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<BoxCollider2D>() != null)
        {
            spriteRenderer.sprite = originalSprite;
        }
    }
}
