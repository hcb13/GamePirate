using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField]
    private GameObject explosionPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 5f);
        Destroy(gameObject);
    }


}
