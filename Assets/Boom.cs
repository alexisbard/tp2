using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    private static LayerMask ballLayer;

    private void Awake()
    {
        ballLayer = LayerMask.NameToLayer("Projectile");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == ballLayer)
            Destroy(gameObject);
    }
}
