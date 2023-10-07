using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : Life
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            ChangeLife(-1);
        }
    }
}