using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private bool isFacingRight = true;
    private bool isInside = false;
    public float speed = 1f;
    
    void Start()
    {
        transform.position = new Vector3(-21.06f, 16.64f, 0);
    }

    void Update()
    {
        if (isInside)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
            transform.Translate(Vector3.up * verticalInput * speed * Time.deltaTime);

            Flip();

            if(transform.position.y >= 16.64)
            {
                transform.position = new Vector3(transform.position.x, 16.64f, 0);
            }

            if (transform.position.x <= -21.43 && transform.position.y <= 16)
            {
                transform.position = new Vector3(-21.43f, transform.position.y, 0);
            }
        }
        
        switchToPlayer();
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

    private void switchToPlayer()
    {
        if (Input.GetKeyUp(KeyCode.E))
        {
            if (isInside)
            {
                isInside = false;
                Player.SetActive(true);
            }else
            {
                isInside = true;
                Player.SetActive(false);
            }
        }
    }

}

