using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Mover : MonoBehaviour

{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotationSpeed;
    [SerializeField] float jumpForce = 300f;
    Rigidbody rb;
    bool playerIsOnTheGround = true;
     
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        PrintInstructions();
    }
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
         Debug.Log("Welcome to the game");
         Debug.Log("Move your player with WASD or arrow keys");
         Debug.Log("Don't hit the walls");
    }

    void MovePlayer()
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

        if (Input.GetKeyDown(KeyCode.Space) && playerIsOnTheGround == true)
        {
           rb.AddForce(Vector3.up * jumpForce);
           playerIsOnTheGround = false;

        }
    }

    void OnCollisionEnter(Collision collision)
    
    {
        if(collision.gameObject.tag == "Ground")
        
        {
            playerIsOnTheGround = true;
        }
    }   
}
