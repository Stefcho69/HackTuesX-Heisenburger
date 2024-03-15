using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRespawn : MonoBehaviour
{
 public void Restartlevel()
    {
        Time.timeScale = 1;
        CollisionLogic.health = 3;
        SceneManager.LoadScene(0);
    }
}
