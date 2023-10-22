using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool player1 = true;
    
    [Header("Movement")]
    public float speed = 10;
    
    [Header("Shooting")]
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 1;

    private void Start()
    {
        InvokeRepeating(nameof(Fire), fireRate, fireRate);
    }

    void Fire()
    {
        Instantiate(bulletPrefab, firePoint.position, transform.rotation);
    }

    void Update()
    {
        var direction = new Vector3();

        if (player1)
        {
            direction.x = Input.GetAxis("Horizontal");
            direction.z = Input.GetAxis("Vertical");
        }
        else
        {
            direction.x = Input.GetAxis("Horizontal2");
            direction.z = Input.GetAxis("Vertical2");
        }
        
        transform.position += direction * speed * Time.deltaTime;
        
        if(direction != Vector3.zero)
            transform.forward = direction;
    }
}
