using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab; 
    [SerializeField]
    private Transform shootPoint; 

    public void Shoot()
    {
        if (bulletPrefab != null && shootPoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
            BulletMovement bulletMovement = bullet.GetComponent<BulletMovement>();
            if (bulletMovement != null)
            {
                bulletMovement.SetDirection(transform.forward); 
            }
        }
    }
}
