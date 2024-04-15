using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QuestLogic : MonoBehaviour
{
    public static QuestLogic instance;
    public TMP_Text quest_text;
    public int currenttrash;
    public bool isDone = false;

    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        currenttrash = TrashCounter.instance.currenttrash;
        if (currenttrash < 40)
        {
       quest_text.text = "You have collected " + currenttrash.ToString() + "/40 trash units";
        }

        else {
            isDone = true;
            quest_text.text = "Quest Done!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        currenttrash = TrashCounter.instance.currenttrash;
        if (currenttrash < 40)
        {
            quest_text.text = "You have collected " + currenttrash.ToString() + "/40 trash units";
        }

        else
        {
            isDone = true;
            quest_text.text = "Quest Done!";
        }
    }

}