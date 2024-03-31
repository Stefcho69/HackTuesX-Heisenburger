using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject Submarine;
    [SerializeField] private float speed = 2.0f;
    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Submarine.transform.position, speed * Time.deltaTime);
        transform.right = (Submarine.transform.position - transform.position) * -1;

        if (transform.position.y >= 16)
        {
            transform.position = new Vector3(transform.position.x, 16f, 0);
        }

        if (transform.position.x <= -17.67 && transform.position.y >= 14)
        {
            transform.position = new Vector3(-17.67f, 14f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("BOOM");
        }
    }
}
