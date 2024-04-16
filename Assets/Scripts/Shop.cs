using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cosmetic1()
    {
        if (coinsCounter.instance.currentcoins >= 3)
        {
            coinsCounter.instance.currentcoins -= 3;
            coinsCounter.instance.coins.text = "Coins: " + coinsCounter.instance.currentcoins.ToString();

        }
    }
}
