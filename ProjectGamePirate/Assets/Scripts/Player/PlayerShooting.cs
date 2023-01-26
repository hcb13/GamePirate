using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private GameObject cannonBallPrefab;
    [SerializeField]
    private float bulletForce = 20f;

    public void OnFrontalShoot(InputAction.CallbackContext value)
    {
        if (value.performed)
        {
            GameObject cannonBall = Instantiate(cannonBallPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = cannonBall.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint.up * -1 * bulletForce;
        }
    }

}
