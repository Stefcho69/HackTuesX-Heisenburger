using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    [SerializeField] private GameObject Submarine;
    [SerializeField] private float speed = 2.0f;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Submarine.transform.position, speed * Time.deltaTime);
        transform.right = (Submarine.transform.position - transform.position) * -1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("BOOM");
        }
    }
}
