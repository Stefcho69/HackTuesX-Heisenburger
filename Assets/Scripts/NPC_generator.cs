using System.Collections;
using System.Collections.Generic;
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
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(NPC_spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator NPC_spawn()
    {
        int choice = Random.Range(1, 2);
        for (int i = 0; i < interval; i++)
        {
            yield return new WaitForSeconds(1);
            float x = player.transform.position.x;
            float y = player.transform.position.y;

            /*switch (choice)
            {
                case 1:
                    Instantiate(enemy_variant_1, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                    choice = 2;
                    break;
                case 2:
                    Instantiate(enemy_variant_2, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                    choice = 1;
                    break;
            }*/
            for(int j=0; j < count; j++)
            {
                switch (j % 5)
                {
                    case 0:
                        Instantiate(fish_1, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(fish_2, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(fish_3, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        break;
                    case 3:
                        Instantiate(fish_4, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        break;
                    case 4:
                        Instantiate(fish_5, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        break;
                }
            }
        }
    }
}
