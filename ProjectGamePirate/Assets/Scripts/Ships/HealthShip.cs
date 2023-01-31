using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthShip : MonoBehaviour
{

    [SerializeField]
    private Image healthBar;

    [SerializeField]
    private float damage = 0.10f;

    public Action<float> OnUpdateHealth = delegate { };


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("CannonBall"))
        {
            healthBar.fillAmount -= damage;

            OnUpdateHealth?.Invoke(healthBar.fillAmount);
        }
    }

    public void Spawn()
    {
        healthBar.fillAmount = 1;
    }


}
