using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Airbar : MonoBehaviour
{
    public static Airbar instance;
    public Transform Submarine;
    public GameObject Player;
    public Image Bar;
    public Image Border;
    public float air = 100f;
    public float airCap = 3;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Bar.fillAmount = air / 100f;
        if (!Player.activeInHierarchy && Submarine.position.y < 16.4)
        {
            air -= Time.deltaTime * airCap;
            
        }

        if(Submarine.position.y >= 16.4)
        {
            air += Time.deltaTime * 5;
        }

        if (air < 18f)
        {
            Border.color = Color.red;
            
        }
        else
        {
            Border.color = Color.black;
        }

        if(air > 100f)
        {
            air = 100f;
        }
    }
}
