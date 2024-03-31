using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class TriggerQuest : MonoBehaviour
{
    [SerializeField] string tagFilter;

    [SerializeField] UnityEvent onTiggerEnter;
    [SerializeField] UnityEvent onTiggerExit;
    void Start()
    {
        Debug.Log("The script is used");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("The trigger has kinda been triggered");
        if (other.gameObject.CompareTag(tagFilter))
        {
            onTiggerEnter.Invoke();
            Debug.Log("The trigger was triggered");
        }
        
    }

     void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(tagFilter))
        {
            Debug.Log("The trigger was triggered");
            onTiggerExit.Invoke();
        }
            

    }
}
