using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Movement : MonoBehaviour
{
    public float damageOnContact = 9f;
    public float moveSpeed = 3f;
    public float moveRange = 3f;
    private bool movingRight = true;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        Move();

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