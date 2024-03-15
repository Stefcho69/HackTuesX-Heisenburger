using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    [SerializeField] GameObject enemy_variant_1;
    [SerializeField] GameObject enemy_variant_2;
    [SerializeField] GameObject player;
    [SerializeField] int interval;
    [SerializeField] int count_of_enemies;
    void Start()
    {
        StartCoroutine(Spawn_Enemy());
    }

    void Update()
    {
    }

    IEnumerator Spawn_Enemy()
    {
        int choice = Random.Range(1, 2);
        for (int i=0; i<interval; i++)
        {
            yield return new WaitForSeconds(1);
            float x = player.transform.position.x;
            float y = player.transform.position.y;
            
                switch (choice)
                {
                    case 1:
                        Instantiate(enemy_variant_1, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        choice = 2;
                        break;
                    case 2:
                        Instantiate(enemy_variant_2, new Vector2(Random.Range(x - 10, x + 10), Random.Range(x - 10, x + 10)), Quaternion.identity);
                        choice = 1;
                        break;
                }
        }
    }


}
