using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderCode : MonoBehaviour
{
    public Rigidbody onCilinder;
    public Vector3 Velocity;

    private void Start()
    {
        onCilinder.AddForce(Velocity, ForceMode.VelocityChange);
    }

    private void Update()
    {
    }
}
