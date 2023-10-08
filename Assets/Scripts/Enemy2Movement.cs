using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy2Movement : MonoBehaviour
{
    public float damageOnContact = 9f;
    public float moveSpeed = 3f;
    public float moveRange = 3f;
    private bool movingRight = true;
    private Vector3 initialPosition;

    private Shooter shooter;
    private float nextFireTime = 0f; 
    public float fireRate = 1f;

    void Start()
    {
        initialPosition = transform.position;
        shooter = GetComponent<Shooter>();
    }

    void Update()
    {
        Move();

        if (Time.time >= nextFireTime)
        {
            if (shooter != null)
            {
                shooter.Shoot();
                nextFireTime = Time.time + fireRate; 
            }
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
}
