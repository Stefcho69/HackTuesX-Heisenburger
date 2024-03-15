using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFishy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Message");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Message");
            CollisionLogic.health -= 1;
        }
    }
}
