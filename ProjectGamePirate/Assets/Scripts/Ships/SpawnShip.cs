using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnShip : MonoBehaviour
{
    [SerializeField]
    private Transform initPosition;

    public void Respawn()
    {
        GetComponent<HealthShip>().Spawn();
        transform.position = initPosition.position;
        transform.rotation = initPosition.rotation;
        WaitToSpawn();
        gameObject.SetActive(true);
    }

    private IEnumerator WaitToSpawn()
    {
        yield return new WaitForSeconds(2f);
        
        
    }

}
