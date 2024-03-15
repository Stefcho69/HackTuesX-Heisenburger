using UnityEngine;

public class NPC_movement : MonoBehaviour
{
    public float speed = 1.0f;
    public float leftBoundary = -21.0f;
    public float rightBoundary = 152.0f;

    private bool movingRight = false;
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= rightBoundary)
            {
                transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
                movingRight = false;
                transform.Rotate(180.0f, 180.0f, 0.0f, Space.World);
                //Flip();
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= leftBoundary)
            {
                transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
                movingRight = true;
                transform.localScale = originalScale;
            }
        }
    }

    private void Flip()
    {
        /*float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (movingRight && horizontalInput < 0f || !movingRight && horizontalInput > 0f)
        {

            movingRight = !movingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }*/
        
    }
}