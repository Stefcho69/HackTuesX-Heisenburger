using UnityEngine;

public class Movement : MonoBehaviour
{
    private bool isFacingRight = true;
    public float speed = 1f;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        
    }

    void Update()
    {
      
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        transform.Translate(Vector3.up * verticalInput *speed * Time.deltaTime);

        Flip();
    }
   
    private void Flip()
    {       
        float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
        if (isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}

