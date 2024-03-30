using System.Collections;
using UnityEngine;

public class NPC_generator : MonoBehaviour
{
    [SerializeField] GameObject fish_1;
    [SerializeField] GameObject fish_2;
    [SerializeField] GameObject fish_3;
    [SerializeField] GameObject fish_4;
    [SerializeField] GameObject fish_5;
    [SerializeField] GameObject player;
    [SerializeField] int interval;
    [SerializeField] int count;
    void Start()
    {
        StartCoroutine(NPC_spawn());
    }

    IEnumerator NPC_spawn()
    {
        for (int i = 0; i < interval; i++)
        {
            yield return new WaitForSeconds(1);
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            if (x > 143)
            {
                x -= 10;
            }
            else if (x < -11)
            {
                x += 10;
            }

            if (y > 5.99)
            {
                y -= 10;
            }
            else if (y < -5.99)
            {
                y += 10;
            }

            switch (i % 5)
            {
                case 0:
                    Instantiate(fish_1, new Vector2(Random.Range(x - 10, x + 10), Random.Range(y - 10, y + 10)), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(fish_2, new Vector2(Random.Range(x - 10, x + 10), Random.Range(y - 10, y + 10)), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(fish_3, new Vector2(Random.Range(x - 10, x + 10), Random.Range(y - 10, y + 10)), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(fish_4, new Vector2(Random.Range(x - 10, x + 10), Random.Range(y - 10,y + 10)), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(fish_5, new Vector2(Random.Range(x - 10, x + 10), Random.Range(y - 10, y + 10)), Quaternion.identity);
                    break;
            }
        }
    }
}
