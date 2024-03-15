using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewBehaviourScript : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 16f;
    private bool isFacingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    void Update()
    {  
        horizontal = UnityEngine.Input.GetAxisRaw("horizontal");

        if(UnityEngine.Input.GetButtonDown("Jump") && isGrounded()){
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower );
        }
        if (UnityEngine.Input.GetButtonDown("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        Flip();
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void FixedUpdate()
    {

        rb.velocity = new Vector2((horizontal * speed), rb.velocity.y);

    }


    private void Flip()
    {
        if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x = -1f;
            transform.localScale = localScale;
        }
    }
}
