using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TrashCounter : MonoBehaviour
{
    public static TrashCounter instance;
    public TMP_Text trashtext;
    public int currenttrash = 0;
    private void Awake()
    {
        instance = this;

    }
    void Start()
    {
        trashtext.text = "Trash: " + currenttrash.ToString();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseTrash(int v)
    {
        currenttrash += v;
        trashtext.text = "Trash: " + currenttrash.ToString();
    }
}