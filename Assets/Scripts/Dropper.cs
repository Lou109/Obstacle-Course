using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timetoWait = 5f;

    void Update()
    {
        if (Time.time > timetoWait)
        {
            Debug.Log( timetoWait + " seconds has elaspsed");
        }
    }
}
