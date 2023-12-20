using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
   [SerializeField] float timetoWait = 5f;

    void Start()
    {
       
    }

    void Update()
    {
        if(Time.time > timetoWait)
        {
            Debug.Log("3 seconds has elapsed");
        }
    }
}
