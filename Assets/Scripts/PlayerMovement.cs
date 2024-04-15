using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool canMove = true;
    public float speed = 1f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (canMove)
        {
         transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        }
      

        if (Input.GetKeyDown(KeyCode.Space) && canMove)
        {
            Debug.Log("JUMP");
            rb.AddForce(new Vector2(rb.velocity.x, 150));
        }
    }
}
