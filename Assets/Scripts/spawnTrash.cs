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
    public float x1 = -21.5f;
    public float y1 = 16.0f;
    public float x2 = 153.0f;
    public float y2 = -16.1f;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector2 pos = new Vector2(Random.Range(x1, y1), Random.Range(x2, y2));
            Instantiate(Water, pos);
            timer = 10;
        }
        
    }

    private void Instantiate(GameObject water, Vector2 pos)
    {
        throw new System.NotImplementedException();
    }
}
