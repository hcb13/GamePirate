using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShip : MonoBehaviour
{
    private Transform initPosition;

    private void Awake()
    {
        initPosition = transform;
    }

    public void Respawn()
    {
        GetComponent<HealthShip>().Spawn();
        transform.position = initPosition.position;
        transform.rotation = initPosition.rotation;
        gameObject.SetActive(true);
    }

    private IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(2f);
        
        
    }

}
