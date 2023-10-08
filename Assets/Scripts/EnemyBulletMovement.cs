using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]
    private float speed;

    private Vector3 direction; 

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Vector3 forwardDirection = transform.forward;
        SetDirection(forwardDirection);
    }

    public void SetDirection(Vector3 direction)
    {
        this.direction = direction.normalized;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = direction * speed;
    }
}
