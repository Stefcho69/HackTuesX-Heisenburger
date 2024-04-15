using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class get_reward : MonoBehaviour
{
    public bool rewardGiven = false;
    //IMPORTANT!! this script is used on the questdesc object not on get_reward
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject objectToActivate;

    void Update()
    {
        if(objectToActivate == null)
        {
            rewardGiven = true;
        }
        if (TrashCounter.instance.currenttrash > 39 && rewardGiven == false)
        {
            // Activating a specific GameObject
            objectToActivate.SetActive(true);
        }
    }

}
