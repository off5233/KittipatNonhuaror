using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public bool sa = true;
    bool getitem = true;
    public GameObject gameObject;
    public GameObject gameObjectB;
    public float x, y;
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
                gameObjectB.transform.position = new Vector3(x, y, transform.position.z);
         }
    }
    void OnTriggerExit2D(Collider2D other)
    {

        gameObjectB.transform.position = new Vector3(x, y + 40, transform.position.z);

    }
    void OnTriggerStay2F(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (Input.GetKeyDown("e")){
                if (getitem == true)
                {

                    gameObject.SetActive(true);
                    getitem = false;
                    return;
                }
                if (getitem == false)
                {

                    gameObject.SetActive(false); 
                    return;
                }
            }
        }
    }

}
