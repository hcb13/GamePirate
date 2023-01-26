using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSideShoot : MonoBehaviour
{
    [SerializeField]
    private Transform firePoint1;

    [SerializeField]
    private Transform firePoint2;

    [SerializeField]
    private Transform firePoint3;

    [SerializeField]
    private Transform firePoint4;

    [SerializeField]
    private Transform firePoint5;

    [SerializeField]
    private Transform firePoint6;

    [SerializeField]
    private GameObject cannonBallPrefab;
    [SerializeField]
    private float bulletForce = 20f;

    public void OnSideShoot(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            GameObject cannonBall = Instantiate(cannonBallPrefab, firePoint1.position, firePoint1.rotation);
            Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint1.right * bulletForce;

            cannonBall = Instantiate(cannonBallPrefab, firePoint2.position, firePoint2.rotation);
            rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint2.right * bulletForce;

            cannonBall = Instantiate(cannonBallPrefab, firePoint3.position, firePoint3.rotation);
            rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint3.right * bulletForce;

            cannonBall = Instantiate(cannonBallPrefab, firePoint4.position, firePoint4.rotation);
            rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint4.right * -1 * bulletForce;

            cannonBall = Instantiate(cannonBallPrefab, firePoint5.position, firePoint5.rotation);
            rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint5.right * -1 * bulletForce;

            cannonBall = Instantiate(cannonBallPrefab, firePoint6.position, firePoint6.rotation);
            rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint6.right * -1 * bulletForce;
        }
    }
}
