using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minfoitem2 : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject gameObjectToMove;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {

        gameObject.transform.position = gameObjectToMove.transform.position;

    }
}
