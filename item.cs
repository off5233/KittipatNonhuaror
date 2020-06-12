using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public GameObject gameObject;
    public bool check = true , getitem = true;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown("q")) { 
            if (check == true)
        {
   
                transform.position = new Vector3(transform.position.x, transform.position.y - 29f, transform.position.z);
                check = false;
                return;
            }
            if (check == false)
            {

                transform.position = new Vector3(transform.position.x, transform.position.y + 29f, transform.position.z);
                check = true;
                return;
            }
        }

       /* if (Input.GetKeyDown("e"))
        {
            if (getitem == true)
            {

                gameObject. transform.position = new Vector3(transform.position.x, transform.position.y - 29f, transform.position.z);
                getitem = false;
                return;
            }
            if (getitem == false)
            {

                gameObject.transform.position = new Vector3(transform.position.x, transform.position.y + 29f, transform.position.z);
                getitem = true;
                return;
            }
        }*/
    }
}
