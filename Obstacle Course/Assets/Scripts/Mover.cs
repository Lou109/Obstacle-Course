using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{
    void Start()
    {
       
    }

    void Update()
    {
         float xValue = Input.GetAxis("Horizontal");
         float zValue = Input.GetAxis("Vertical");
         transform.Translate(xValue,0,zValue);
    }
}
