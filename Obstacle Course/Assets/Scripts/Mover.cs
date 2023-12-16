using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed;
     
    void Start()
    {
       
    }
    void Update()
    {
        float xValue = Input.GetAxis ("Horizontal");
        float zValue = Input.GetAxis ("Vertical");

        Vector3 movementDirection = new Vector3 (xValue, 0 , zValue);
        movementDirection.Normalize();

        transform.Translate (movementDirection * moveSpeed * Time.deltaTime, Space.World); 

        if (movementDirection != Vector3.zero)

        {
            Quaternion toRotation = Quaternion.LookRotation (movementDirection, Vector3.up);
            transform.rotation = Quaternion. RotateTowards (transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
}
