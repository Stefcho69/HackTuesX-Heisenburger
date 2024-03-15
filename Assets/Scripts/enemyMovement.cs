using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject Submarine;
    [SerializeField] private float speed = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Submarine.transform.position, speed * Time.deltaTime);
        transform.right = (Submarine.transform.position - transform.position) * -1;
    }
}
