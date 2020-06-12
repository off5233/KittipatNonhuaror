using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    bool chack = false ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            if (chack = false)
            {
                transform.position = new Vector2(0, 0);
                chack = true;
            }
        }
        if (Input.GetKey("e"))
        {
            if (chack = true)
        {
            
                transform.position = new Vector2(0, 40);
                chack = false;
            }
        }
    }
}
