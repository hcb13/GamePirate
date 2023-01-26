using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    [SerializeField]
    private List<Transform> waypoints;

    [SerializeField]
    private int target;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float distanceOfWaypoints = 0.1f;

    [SerializeField]
    private bool isFacingRight = false;

    [SerializeField]
    private GameObject visionShip;

    private Rigidbody2D _rigidbody;

    private bool isMoving = true;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

        visionShip.GetComponent<EnemyShoot>().OnIsAttacking += Attacking;
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            if (Vector2.Distance(transform.position, waypoints[target].position) <= distanceOfWaypoints)
            {
                if (target == waypoints.Count - 1)
                {
                    target = 0;
                }
                else
                {
                    target += 1;
                }
                isFacingRight = !isFacingRight;
                transform.rotation = Quaternion.Inverse(transform.rotation);
            }

            float horizontalVelocity = speed * -1f;

            if (isFacingRight)
            {
                horizontalVelocity *= -1f;
            }

            _rigidbody.velocity = new Vector2(horizontalVelocity,
                                                _rigidbody.velocity.y);

        }
        else
        {
            _rigidbody.velocity = Vector2.zero;
        }
    }

    private void Attacking(bool isAttacking)
    {
        isMoving = !isAttacking;
    }

}
