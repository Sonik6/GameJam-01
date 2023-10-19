using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce;

    public float moveSpeed = 10;
    public bool inputBlock;
    
    private Rigidbody2D rb;
    private bool isGrounded;

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(horizontalInput, 0) * moveSpeed * Time.deltaTime);
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Jump();
        }


        
        {
            
        }
    }

    void FixedUpdate()
    {
        // LayerMask for the ground layer (adjust this in the Unity Inspector).
        int groundLayerMask = 1 << LayerMask.NameToLayer("Ground");

        // Perform ground detection using a 2D raycast.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1.0f, groundLayerMask);

        // If the ray hits something, the player is grounded.
        isGrounded = (hit.collider != null);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}