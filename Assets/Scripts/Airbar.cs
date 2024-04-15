using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Airbar : MonoBehaviour
{
    public Transform Submarine;
    public GameObject Player;
    public Image Bar;
    public float air = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bar.fillAmount = air / 100f;
        if (!Player.activeInHierarchy && Submarine.position.y < 16.4)
        {
            air -= Time.deltaTime;
            
        }

        if(Submarine.position.y >= 16.4)
        {
            air += Time.deltaTime * 2;
        }

        if (air < 0)
        {
            Debug.Log("Breathe Air!");
        }

        if(air > 100f)
        {
            air = 100f;
        }
    }
}
