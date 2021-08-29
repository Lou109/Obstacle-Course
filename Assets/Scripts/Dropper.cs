using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mRenderer;
    Rigidbody rBody;
    [SerializeField] float timetoWait = 5f;

    void Start()
    { 
        mRenderer = GetComponent<MeshRenderer>();
        rBody = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        rBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timetoWait)
        {
            mRenderer.enabled = true;
            rBody.useGravity = true;
        }
    }
}
