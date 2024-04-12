using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public GameObject Player;
    public Transform target2;
    public Vector3 offset = new Vector3(0, 0, -10);
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        if(Player.activeInHierarchy)
        {
            transform.position = target2.position + offset;
        }
        else
        {
            transform.position = target.position + offset;
        }
        

        if (transform.position.x <= -12.28 && transform.position.y <= 16)
        {
            transform.position = new Vector3(-12.26f, transform.position.y, -10);
        }

        if (transform.position.x >= 143.64)
        {
            transform.position = new Vector3(143.62f, transform.position.y, -10);
        }

        if (transform.position.y <= -11.72)
        {
            transform.position = new Vector3(transform.position.x, -11.72f, -10);
        }
    }

}