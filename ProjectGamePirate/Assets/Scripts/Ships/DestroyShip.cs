using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{

    private void Awake()
    {
        GetComponent<HealthShip>().OnUpdateHealth += OnDestroyShip;        
    }

    private void OnDestroyShip(float health)
    {
        if(health <= 0.05)
        {
            StartCoroutine(WaitToDestroy());
        }
    }

    private IEnumerator WaitToDestroy()
    {
        yield return new WaitForSeconds(1f);
        gameObject.SetActive(false);
        
        GameObject gamePoints = GameObject.FindGameObjectsWithTag("GamePoints")[0];
        gamePoints.GetComponent<GamePoints>().IncreasePoints();

        GetComponent<SpawnShip>().Respawn();
    }

    
}
