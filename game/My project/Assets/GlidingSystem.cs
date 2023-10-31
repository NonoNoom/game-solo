using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlidingSystem : MonoBehaviour
{
    [SerializeField] private float BaseSpeed = 30f;
    [SerializeField] private float MaxThrustSpeed;
    [SerializeField] private float MinThrustSpeed;
    private float CurrentThrustSpeed;
    private Rigidbody Rb;


    private void Start(){
        Rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate(){
        GlidingMovement();
    }

    private void Update(){

    }

    private void GlidingMovement(){
        Rb.AddRelativeForce(-Vector3.forward * BaseSpeed);
    }

    private void ManageRotation(){

    }
}
