﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Re : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("r"))
        {
            transform.position = new Vector3(31, 49, -29);
        }
        if(Input.GetKey("/"))
        {
            transform.position = new Vector3(114, 20, 20);
        }
    }
}
