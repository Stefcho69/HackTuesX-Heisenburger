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
        coinsCounter.instance.coins.text = "Coins: " + coinsCounter.instance.currentcoins.ToString();
    }

    public void Cosmetic1()
    {
        if (coinsCounter.instance.currentcoins >= 3)
        {
            coinsCounter.instance.currentcoins -= 3;
            coinsCounter.instance.coins.text = "Coins: " + coinsCounter.instance.currentcoins.ToString();
            Movement.instance.gameObject.GetComponent<SpriteRenderer>().sprite = Movement.instance.newSprite;
        }
    }

    public void Cosmetic2()
    {
        if (coinsCounter.instance.currentcoins >= 4)
        {
            coinsCounter.instance.currentcoins -= 4;
            coinsCounter.instance.coins.text = "Coins: " + coinsCounter.instance.currentcoins.ToString();
            Movement.instance.gameObject.GetComponent<SpriteRenderer>().sprite = Movement.instance.newSprite2;
        }
    }

    public void Speed()
    {
        if(coinsCounter.instance.currentcoins >= 7)
        {
            coinsCounter.instance.currentcoins -= 7;
            Movement.instance.speed += 4f;
        }
    }

    public void AirCapacity()
    {
        if (coinsCounter.instance.currentcoins >= 8)
        {
            coinsCounter.instance.currentcoins -= 8;
            Airbar.instance.airCap -= 0.3f;
        }
    }
}
