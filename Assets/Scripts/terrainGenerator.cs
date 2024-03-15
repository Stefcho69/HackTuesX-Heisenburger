using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] int x;
    [SerializeField] int y;
    [SerializeField] int width;
    [SerializeField] int height;
    [SerializeField] GameObject square;
    void Start()
    {
        generation();
    }

    void Update()
    {

    }

    void generation()
    {
        for (int i = x; i < width; i++)
        {
            Instantiate(square, new Vector3(i, y, 0), Quaternion.identity);
            float placeholder = Random.Range(1, height);
            for (int j = 1; j < placeholder; j++)
            {
                Instantiate(square, new Vector3(i, y + j, 0), Quaternion.identity);
            }
        }
    }
}