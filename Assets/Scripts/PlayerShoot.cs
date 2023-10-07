using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject smallbulletPrefab;
    public GameObject bigbulletPrefab;
    private PlayerMovement playerMovement;

    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }


    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject obj = Instantiate(smallbulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(playerMovement.Direction);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GameObject obj = Instantiate(bigbulletPrefab);
            obj.transform.position = transform.position;
            obj.GetComponent<BulletMovement>().SetDirection(playerMovement.Direction);
        }
    }
}