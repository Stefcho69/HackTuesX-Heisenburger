using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exchange : MonoBehaviour
{
    public void ExchangeTrashToCoins()
    {
        if(TrashCounter.instance.currenttrash >= 20)
        {
            coinsCounter.instance.currentcoins += TrashCounter.instance.currenttrash / 20;
            TrashCounter.instance.currenttrash -= 20 * coinsCounter.instance.currentcoins;
        }
        
        coinsCounter.instance.coins.text = "Coins: " + coinsCounter.instance.currentcoins.ToString();
        TrashCounter.instance.trashtext.text = "Trash: " + TrashCounter.instance.currenttrash.ToString();
    }
}
