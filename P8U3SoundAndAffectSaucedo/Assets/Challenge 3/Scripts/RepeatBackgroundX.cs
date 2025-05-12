using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    public float repeat;

     void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        
        if (transform.position.x < startPos.x - repeat)
        {
            transform.position = startPos;
        }
    }

 
}


