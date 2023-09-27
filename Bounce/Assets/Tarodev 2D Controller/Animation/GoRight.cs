using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoRight : MonoBehaviour
{
    public Animator animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject.
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the right arrow key is pressed.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Play the animation.
            animator.SetBool("IsMovingRight", true);
        }
        else
        {
            // Stop the animation when the key is released.
            animator.SetBool("IsMovingRight", false);
        }
    }
}
