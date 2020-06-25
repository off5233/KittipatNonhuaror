using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A : MonoBehaviour {
public GameObject gameObjectToMove;
public GameObject gameObject;
public GameObject gameObjectitem;
public float x, y;
void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameObjectitem.transform.position = gameObjectToMove.transform.position;
            Time.timeScale = 1;
            gameObject.transform.position = new Vector3(100, 100, transform.position.z);
        }
    }
}