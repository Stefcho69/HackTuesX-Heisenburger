using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class coinsCounter : MonoBehaviour
{
    public static coinsCounter instance;
    public TMP_Text coins;
    public int currentcoins = 0;
    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        coins.text = "Coins: " + currentcoins.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }
}