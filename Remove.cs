using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remove : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision Des)
    {
        if (Des.gameObject.name == "itemtoopen")
        {
            Destroy(GameObject.Find("wall"));
        }
    }
}
