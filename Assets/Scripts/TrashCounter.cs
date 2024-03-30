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

    public void IncreaseTrash(int v)
    {
        currenttrash += v;
        trashtext.text = "Trash: " + currenttrash.ToString();
    }
}