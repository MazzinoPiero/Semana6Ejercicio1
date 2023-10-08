using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3Shooter : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float fireRate = 2f;
    private float nextFireTime = 0f;

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    public void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.Euler(0, 90, 0));
        Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.Euler(0, -90, 0));
    }
}
