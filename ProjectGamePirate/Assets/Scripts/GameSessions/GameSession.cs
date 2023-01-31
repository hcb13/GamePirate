using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour
{
    [SerializeField]
    private float endSession = 1f;
    [SerializeField]
    private float time;

    private bool sessionEnded;

    private void Start()
    {
        time = endSession * 60;
        sessionEnded = false;
    }

    private void Update()
    {
        if (!sessionEnded)
        {
            if (time <= 0 )
            {
                // end session
                sessionEnded = true;
                SessionEnded();
            }
            time -= Time.deltaTime;
        }
    }


    private void SessionEnded()
    {
        SceneManager.LoadScene("GameOver");
    }
}
