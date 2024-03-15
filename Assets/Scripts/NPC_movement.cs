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
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x >= rightBoundary)
            {
                transform.position = new Vector3(rightBoundary, transform.position.y, transform.position.z);
                movingRight = false;
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= leftBoundary)
            {
                transform.position = new Vector3(leftBoundary, transform.position.y, transform.position.z);
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = true;
            }
        }
    }
}