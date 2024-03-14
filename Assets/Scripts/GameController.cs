using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Vector2 startPos;
    Rigidbody2D playerRb;
    private void Awake()
    {
   playerRb= GetComponent<Rigidbody2D>();
    }
    private void Start()
    {

        startPos = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collusion)
    {
        if (collusion.CompareTag("Obstacle"))
        {
            Die();
        }
    }
    void Die()
    {
        StartCoroutine(Respawn(0.5f));
    }
    IEnumerator Respawn(float duration)
    {
        playerRb.simulated = false;
        transform.localScale = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(duration);
        transform.position = startPos;
        transform.localScale = new Vector3(1, 1, 1);
        playerRb.simulated = true;
    }

}
