using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveZONES1 : MonoBehaviour
{
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
    int checkcodeinput = 0;
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
            if (checkcodeinput == 0)
            {
                {
                    {
                        CHAT.NumberChat = 17;
                        Textbox.SetActive(true);
                        Textchar.SetActive(true);
                        BGBLACK.SetActive(true);
                        FaceStart.SetActive(true);
                        CHAT.checkinputpp = 1;
                        MOveCilck.checkmove = 0;
                        checkcodeinput = 1;
                        return;

                    }
                }
            }

        }

    }
}
