using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float jumpForce = 0f;
    public float moveSpeed = 5;
    public bool canJump = true;
    private Rigidbody2D rb;
    private bool isGrounded;
    private SpriteRenderer sr;
    private float length;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector3 itemSize = sr.bounds.size;
        float pixelsPerUnit = sr.sprite.pixelsPerUnit;     
        itemSize.x *= pixelsPerUnit;
        length = itemSize.x;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Debug.Log(isGrounded);
        if (jumpForce == 0.0f && isGrounded)
        {
            Vector3 characterScale = transform.localScale;
            if (Input.GetKey("left") && characterScale.x>0)
            {
                characterScale.x *= -1;
            }
            if (Input.GetKey("right") && characterScale.x < 0)
            {
                characterScale.x *= -1;
            }
            transform.localScale = characterScale;

/*            Debug.Log(jumpForce);
            Debug.Log(isGrounded);*/
            rb.velocity = new Vector2(horizontalInput * (moveSpeed * 0.5f), rb.velocity.y);
        }
        
        if (isGrounded && canJump && Input.GetKey("space"))
        {
            jumpForce += 0.05f;
        }

        if(Input.GetKeyDown("space") && isGrounded && canJump)
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
        }
        
        if(jumpForce >= 8f && isGrounded)
        {
            float tempx = horizontalInput * moveSpeed * 0.6f;
            float tempy = jumpForce;
            rb.velocity = new Vector2(tempx, tempy);       
            Invoke("ResetJump", 0.2f);
        }

        if (Input.GetKeyUp("space"))
        {
            canJump = true;
            if (isGrounded)
            {       
                rb.velocity = new Vector2(horizontalInput * moveSpeed, jumpForce);
                jumpForce = 0f;                
            }
        }
        
    }
    
    void ResetJump() {
        canJump = false;
        jumpForce = 0f;
    }
    void FixedUpdate()
    {
        // LayerMask for the ground layer (adjust this in the Unity Inspector).
        int groundLayerMask = 1 << LayerMask.NameToLayer("Ground");

        // Perform ground detection using a 2D raycast.
        RaycastHit2D hit1 = Physics2D.Raycast(transform.position - new Vector3(0.25f,0,0) , Vector2.down, 1.0f, groundLayerMask);
        RaycastHit2D hit2 = Physics2D.Raycast(transform.position + new Vector3(0.25f,0,0), Vector2.down, 1.0f, groundLayerMask);


        isGrounded = (hit1.collider != null || hit2.collider != null);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}

