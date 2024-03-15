using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TrashCounter : MonoBehaviour
{   
    public static TrashCounter instance;
    public TMP_Text trashtext;
    public int currenttrash = 0;

    // Update is called once per frame
    void Update()
    {
        trashtext.text = "Trash: " + currenttrash;
        if (Input.GetKey(KeyCode.Escape))
        {
            currenttrash++;
        }
    }

    public void IncreaseTrash(int v)
    {
        currenttrash += v;
        trashtext.text = "Trash: " + currenttrash;
    }
}
