using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer myRenderer;
    Rigidbody myRigidbody;
   [SerializeField] float timetoWait = 5f;

    void Start()
    {
        myRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        myRenderer.enabled = false;
        myRigidbody.useGravity = false;
        
    }

    void Update()
    {
        if(Time.time > timetoWait)
        {
            myRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
