using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorShip : MonoBehaviour
{

    private Animator _animator;

    private void Awake()
    {
        _animator= GetComponent<Animator>();

        GetComponent<HealthShip>().OnUpdateHealth += UpdateHealthAnimation;
    }

    private void UpdateHealthAnimation(float health)
    {
        _animator.SetFloat("health", health);
    }


}
