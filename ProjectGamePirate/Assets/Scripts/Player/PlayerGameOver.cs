using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerGameOver : MonoBehaviour
{

    private void Awake()
    {
        GetComponent<HealthShip>().OnUpdateHealth += GameOver;
        GetComponent<PlayerHealth>().OnUpdateHealth += GameOver;
    }

    private void GameOver(float health)
    {
        if(health <= 0.05)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
