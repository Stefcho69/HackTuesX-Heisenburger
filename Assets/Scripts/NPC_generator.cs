using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class NPC_generator : MonoBehaviour
{
    [SerializeField] GameObject fish_1;
    [SerializeField] GameObject fish_2;
    [SerializeField] GameObject fish_3;
    [SerializeField] GameObject fish_4;
    [SerializeField] GameObject fish_5;
    [SerializeField] int interval;
    void Start()
    {
        StartCoroutine(NPC_spawn());
    }

    void Update()
    {

    }

    IEnumerator NPC_spawn()
    {
        for (int i = 0; i > -1; i++)
        {
            yield return new WaitForSeconds(interval);
            float x1 = -18.5f;
            float y1 = 16.0f;
            float x2 = 153.0f;
            float y2 = -16.1f;
            switch (i % 5)
            {
                case 0:
                    Instantiate(fish_1, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(fish_2, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(fish_3, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(fish_4, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(fish_5, new Vector2(Random.Range(x1, x2), Random.Range(y1, y2)), Quaternion.identity);
                    break;
            }
        }
    }
}