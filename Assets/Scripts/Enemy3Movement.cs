using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Movement : MonoBehaviour
{
    public float damageOnContact = 9f;
    public float moveSpeed = 3f;
    public float moveRange = 3f;
    private bool movingRight = true;
    private Vector3 initialPosition;

    private Enemy3Shooter shooter;
    private float nextChangeDirectionTime = 0f;
    public float changeDirectionRate = 5f;

    void Start()
    {
        initialPosition = transform.position;
        shooter = GetComponent<Enemy3Shooter>();
    }

    void Update()
    {
        Move();

        if (Time.time >= nextChangeDirectionTime)
        {
            ChangeDirection();
            nextChangeDirectionTime = Time.time + changeDirectionRate;
        }

        if (shooter != null)
        {
            shooter.Shoot(); 
        }

        if (Vector3.Distance(initialPosition, transform.position) >= moveRange)
        {
            movingRight = !movingRight;
        }
    }

    void Move()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
    }

    void ChangeDirection()
    {
        movingRight = Random.Range(0, 2) == 0;
    }
}
