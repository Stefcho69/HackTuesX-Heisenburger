using UnityEngine;

public class Trash : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            TrashCounter.instance.IncreaseTrash(value);
        }
    }
}