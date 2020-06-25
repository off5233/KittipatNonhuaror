using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigerDoor : MonoBehaviour
{
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
    public GameObject B_E;

    public static int checkevent1 = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (checkevent1 == 1) {
                if (Input.GetKeyDown("e"))
                {
                    { 
                        CHAT.NumberChat = 36;
                        Textbox.SetActive(true);
                        Textchar.SetActive(true);
                        BGBLACK.SetActive(true);
                        FaceStart.SetActive(true);
                        B_E.SetActive(false);
                        CHAT.checkinputpp = 1;
                        MOveCilck.checkmove = 0;
                        checkevent1 = 2;
                        return;

                    }
                }
            }

        }

    }
}
