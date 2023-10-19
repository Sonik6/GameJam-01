using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float walkSpeed;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask groudMask;
    
    public PhysicsMaterial2D bounceMaterial, playerMaterial;
    
    public bool canJump;
    public float jumpValue = 0.0f;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        Debug.Log(canJump);
        Debug.Log(isGrounded);
        
        moveInput = Input.GetAxisRaw("Horizontal");

        if (jumpValue == 0.0f && isGrounded && rb.sharedMaterial == playerMaterial)
        {
            rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
        }
        
        isGrounded = Physics2D.OverlapBox(new Vector2(transform.position.x, transform.position.y ), new Vector2(0.5f, 0.5f), 0, groudMask);
     
        if(isGrounded && canJump)
        {
            rb.sharedMaterial = playerMaterial;
        }
        else
        {
            rb.sharedMaterial = bounceMaterial;
        }
            

        if (Input.GetKey("space") && isGrounded && canJump)
        {
            if (jumpValue < 9f) 
            jumpValue += 0.03f;
        }

        if (Input.GetKeyDown("space") && isGrounded && canJump)
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
        }
        
        /*if (jumpValue >= 9f && isGrounded && canJump )
        {
            float tempx = moveInput * walkSpeed;
            float tempy = jumpValue;
            rb.velocity = new Vector2(tempx, tempy);
            Invoke("ResetJump", 0.3f);
            isGrounded = false;
        }*/   

        if (Input.GetKeyUp("space"))
        {
            if (isGrounded)
            {
                rb.velocity = new Vector2(moveInput * walkSpeed, jumpValue);
                jumpValue = 0.0f;              
            }
            canJump = false;
            isGrounded = false;

            Invoke("SetCanJumpFlag", 0.2f);
        }
        
    }

    void SetCanJumpFlag()
    {
        canJump = true;
    }
    
    void ResetJump()
    {
        /*canJump = false*/;
        jumpValue = 0.0f;
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.5f, 0.5f));
    }
}