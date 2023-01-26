using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private GameObject cannonBallPrefab;
    [SerializeField]
    private float bulletForce = 20f;

    [SerializeField]
    private float waitTime = 1f;

    public Action<bool> OnIsAttacking = delegate { };

    private bool canAttack = true;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && canAttack)
        {

            GameObject cannonBall = Instantiate(cannonBallPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint.up * -1 * bulletForce;

            OnIsAttacking(true);

            StartCoroutine(Wait());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnIsAttacking(false);
        }
    }

    private IEnumerator Wait()
    {
        canAttack = false;
        yield return new WaitForSeconds(waitTime);
        canAttack = true;
    }

}
