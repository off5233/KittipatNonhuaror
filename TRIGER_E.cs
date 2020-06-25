using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIGER_E : MonoBehaviour
{
    public GameObject gameObjectB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D Collision)
    {

        if (Collision.gameObject.name == "player")
        {
            gameObjectB.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        gameObjectB.SetActive(false);
    }
}
