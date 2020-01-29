using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Projectile : MonoBehaviour
{
    void start()
    {
        Destroy(gameObject, 5);
    }
    void OnCollisionEnter()
    {

        Destroy(gameObject);
    }
}
