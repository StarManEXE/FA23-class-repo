using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteOnOverlap : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    public Sprite newSprite;

    private Sprite originalSprite;

    private bool isOverlapping = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        originalSprite = spriteRenderer.sprite;
    }

    void Update()
    {
        if (isOverlapping)
        {
            spriteRenderer.sprite = newSprite;
        }
        else
        {
            spriteRenderer.sprite = originalSprite;
        }
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.GetComponent<BoxCollider2D>() != null)
        {
            isOverlapping = true;
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollider)
    {
        if (otherCollider.GetComponent<BoxCollider2D>() != null)
        {
            isOverlapping = false;
        }
    }
}
