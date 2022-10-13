using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Импульс : MonoBehaviour
{
    public float Radius;
    public float Force;
    
    private void Start()
    {
        Collider[] objects = Physics.OverlapSphere(transform.position, Radius);
        for (int i = 0; i < objects.Length; i++)
        {

            Rigidbody rigidbody = objects[i].attachedRigidbody;
            if (rigidbody)
            {
                rigidbody.AddExplosionForce(Force, transform.position, Radius);
            }

        }
    }
}  
