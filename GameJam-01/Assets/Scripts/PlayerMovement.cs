using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public ParticleSystem dust;
    public float walkSpeed;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask groudMask;
    public SpriteRenderer sr;
    private Animator animator;

    public PhysicsMaterial2D bounceMaterial, playerMaterial;

    public bool canJump;
    public float jumpValue = 0.0f;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        if (jumpValue == 0.0f && isGrounded && rb.sharedMaterial == playerMaterial)
        {
            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                animator.SetFloat("X", -1);
                animator.SetFloat("Y", 0);
            }
            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                animator.SetFloat("X", 1);
                animator.SetFloat("Y", 0);
            }
            rb.velocity = new Vector2(moveInput * walkSpeed, rb.velocity.y);
            CreateDust();
        }

        if (Mathf.Approximately(rb.velocity.magnitude, 0f))
        {
            StopDust();
        }

        isGrounded = Physics2D.OverlapBox(new Vector2(transform.position.x, transform.position.y), new Vector2(0.5f, 0.5f), 0, groudMask);

        if (isGrounded && canJump)
        {
            rb.sharedMaterial = playerMaterial;
        }
        else
        {
            animator.SetFloat("Y", 1);
            rb.sharedMaterial = bounceMaterial;
        }


        if (Input.GetKey("space") && isGrounded && canJump)
        {
            if (jumpValue < 9f)
                jumpValue += 0.03f;
        }



        if (Input.GetKeyDown("space") && isGrounded && canJump)
        {
            animator.SetFloat("Y", -1);
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
            animator.SetFloat("Y", 0);
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
        /*canJump = false*/
        ;
        jumpValue = 0.0f;
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.5f, 0.5f));
    }
    
    void CreateDust()
    {
        dust.Play();
    }

    void StopDust()
    {
        dust.Stop();
    }
    
}