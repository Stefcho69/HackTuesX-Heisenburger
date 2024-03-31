using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float threshold;
    public Vector3 spawnPoint;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < threshold)
        {
            GameManager.health -= 1;
            transform.position = spawnPoint;
        }
    }
}
