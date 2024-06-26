using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 1f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(horizontalInput));
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        animator.SetBool("IsJumpin", true);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("JUMP");
            rb.AddForce(new Vector2(rb.velocity.x, 150));

        }
    }
    public void OnLanding()
    {
        animator.SetBool("IsJumpin", false);
    }
}
