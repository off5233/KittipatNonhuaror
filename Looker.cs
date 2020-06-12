using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour
{
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
    public GameObject gametITEMSHOW;

    public GameObject gameObjectToMove;
    public GameObject gameObjectitem;

    public bool sa = true;
    public static bool getitem = true;
    public GameObject gameObject;
    public GameObject gameObjectB;
    public float x, y;
    int checkitem1 = 0;
    // Start is called before the first frame update
    void Start()
    {

        
    }

 

    // Update is called once per frame
    void Update()
    {
        if (checkitem1 == 1)
        {
            if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
            {
                gameObjectitem.transform.position = gameObjectToMove.transform.position;
                Time.timeScale = 1;

                gametITEMSHOW.SetActive(false);
                CHAT.NumberChat = 13;
                Textbox.SetActive(true);
                Textchar.SetActive(true);
                BGBLACK.SetActive(true);
                FaceStart.SetActive(true);
                CHAT.checkinputpp = 1;
                checkitem1 = 2;
                return;

            }
        }

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
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (Input.GetKeyDown("e")){
                if (getitem == true)
                {
                    gameObject.SetActive(true);
                    Time.timeScale = 0;
                    getitem = false;
                    checkitem1 = 1;
                    return;
                }
            }

        }
        
    }

}
