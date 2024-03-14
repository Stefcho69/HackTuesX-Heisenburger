using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] int width;
    [SerializeField] int height;
    [SerializeField] GameObject kvadrat;
    void Start()
    {
        generation();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void generation()
    {
        for (int i = 0; i < width; i++)
        {
            float y = Random.Range(1, height);
            Instantiate(kvadrat, new Vector2(i, 0), Quaternion.identity);
            for (float j = 1; j < y; j++)
            {
                Instantiate(kvadrat, new Vector2(i, j), Quaternion.identity);
            }
        }
    }
}
