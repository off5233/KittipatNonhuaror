using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cancelinfoitem1 : MonoBehaviour
{
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

        gameObjectToMove.transform.position = new Vector3(transform.position.x - 4.3f, 40f, transform.position.z);

    }
}
