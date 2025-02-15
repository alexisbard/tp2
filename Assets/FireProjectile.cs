﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FireProjectile : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 150;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);
            p.velocity = transform.forward * speed;
        }
    }
}
