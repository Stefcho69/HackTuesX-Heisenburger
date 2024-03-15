using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTrash : MonoBehaviour
{
    [SerializeField] GameObject Water;
    [SerializeField] GameObject Pizza;
    [SerializeField] GameObject Milk;
    [SerializeField] GameObject Cupboard;
    [SerializeField] GameObject Cup;
    [SerializeField] float timer = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Trash_spawn());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Trash_spawn()
    {
        for (int i = 0; i < timer; i++)
        {
            yield return new WaitForSeconds(1);
            float x1 = -21.5f;
            float y1 = 16.0f;
            float x2 = 153.0f;
            float y2 = -16.1f;

            switch (i % 5)
            {
                case 0:
                    Instantiate(Water, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(Pizza, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Milk, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(Cupboard, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(Cup, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
            }
        }
    }
}

