using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suicede_script : MonoBehaviour
{
    [SerializeField] GameObject current_obj;
    [SerializeField] int interval;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DeleteFunc(interval));
        StopCoroutine(DeleteFunc(interval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    IEnumerator DeleteFunc(int interval)
    {
        yield return new WaitForSeconds(interval);
        if(current_obj.name != "fish_gold" && 
            current_obj.name != "fish_bg" && 
            current_obj.name != "fish_cyan" && 
            current_obj.name != "fish_dead" &&
            current_obj.name != "fish_sad" &&
            current_obj.name != "fish_white" &&
            current_obj.name != "fish_angry")
        {
            Destroy(gameObject);
        }
        
    }
}
