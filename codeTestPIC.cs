using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codeTestPIC : MonoBehaviour
{
    public GameObject BGBRED;
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
    public GameObject FaceStart2;
    public GameObject gametPIC1;
    public GameObject gametPIC2;
    public int checkpic1 = 0;
    public static int checkinputE = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkinputE == 1)
        {
            if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
            {
                gametPIC1.SetActive(false);
                CHAT.NumberChat = 5;
                Textbox.SetActive(true);
                Textchar.SetActive(true);
                BGBLACK.SetActive(true);
                FaceStart.SetActive(true);
                CHAT.checkinputpp = 1;
                checkpic1 = 1;
                checkinputE = 3;
                return;

            }
        }
        if (checkinputE == 2)
        {
            if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
            {
                gametPIC2.SetActive(false);
                CHAT.NumberChat = 9;
                Textbox.SetActive(true);
                Textchar.SetActive(true);
                BGBLACK.SetActive(true);
                FaceStart2.SetActive(true);
                CHAT.checkinputpp = 1;
                checkinputE = 3;
                checkpic1 = 2;
                return;

            }
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (checkpic1 == 0)
            {
                if (Input.GetKeyDown("e"))
                {
                    {

                        gametPIC1.SetActive(true);
                        gametPIC2.SetActive(false);
                        MOveCilck.checkmove = 0;
                        checkinputE = 1;
                        return;

                    }
                }
            }
            if (checkpic1 == 1)
            {
                if (Input.GetKeyDown("e"))
                {
                    {
                        BGBRED.SetActive(true);
                        gametPIC1.SetActive(false);
                        gametPIC2.SetActive(true);
                        MOveCilck.checkmove = 0;
                        checkinputE = 2;
                        return;

                    }
                }

            }

        }

    }
}
