using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TruePlayer : MonoBehaviour
{
    private Animator animator;
    private bool canJump;
    private float jumpDelay = 2f; // 2-second delay before jumping
    private float lastJumpTime;

    public float moveSpeed = 5f; // Adjust the player's movement speed here

    void Start()
    {
        animator = GetComponent<Animator>();
        canJump = true;
    }

    void Update()
    {
        // Check if the Z key is pressed and if enough time has passed since the last jump.
        if (Input.GetKeyDown(KeyCode.Z) && canJump && Time.time - lastJumpTime >= jumpDelay)
        {
            // Play the jump animation.
            animator.SetTrigger("Jump");

            // Add your jump logic here.
            Jump();

            // Update the last jump time.
            lastJumpTime = Time.time;

            // Prevent jumping until the delay expires.
            canJump = false;

            // Start a timer to re-enable jumping after the delay.
            StartCoroutine(EnableJumpAfterDelay());
        }

        // Check if the right arrow key is pressed to move forward.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Play the run animation.
            animator.SetBool("IsRunning", true);

            // Move the player forward.
            MoveForward();
        }
        else
        {
            // Stop the run animation.
            animator.SetBool("IsRunning", false);
        }
    }

    void Jump()
    {
        // Implement your jump logic here.
        // For example, you can apply a vertical force to the Rigidbody2D.
        // Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void MoveForward()
    {
        // Move the player forward based on the moveSpeed.
        // You can use a Rigidbody2D or a CharacterController for movement.
        // For simplicity, we'll use transform.Translate here.
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    // Coroutine to re-enable jumping after the delay.
    IEnumerator EnableJumpAfterDelay()
    {
        yield return new WaitForSeconds(jumpDelay);
        canJump = true;
    }
}
