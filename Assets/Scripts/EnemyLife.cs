using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : Life
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet1"))
        {
            ChangeLife(-1);
        }

        if (collision.gameObject.CompareTag("Bullet2"))
        {
            ChangeLife(-3);
        }
    }
}