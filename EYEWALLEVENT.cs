using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EYEWALLEVENT : MonoBehaviour
{

    public AudioClip dIED;
    public AudioSource audioSource;
    public GameObject audioSource1;

    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;

    public GameObject EYEWALL;
    public GameObject BLACKBGWALL;
    int checkpointlight = 1;
    int checkevent = 1;
    int checkevent2 = 1;
    int checkevent3 = 1;
    int checkeventtime = 1;
    float timecheck = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (checkeventtime == 2)
        {
            timecheck = 1f * Time.deltaTime + timecheck;
            if (timecheck >= 1)
            {
                BLACKBGWALL.SetActive(false);
                checkeventtime = 1;
                checkevent = 2;
                timecheck = 0;

                CHAT.NumberChat = 23;
                Textbox.SetActive(true);
                Textchar.SetActive(true);
                BGBLACK.SetActive(true);
                FaceStart.SetActive(true);
                CHAT.checkinputpp = 1;
                MOveCilck.checkmove = 0;

                return;
            }
        }
        if (checkeventtime == 3)
        {
            
            timecheck = 0.5f * Time.deltaTime + timecheck;
            if (timecheck >= 1)
            {
                checkevent3 = 2;
                BLACKBGWALL.SetActive(true);
                checkeventtime = 4;
                checkevent2 = 2;
                timecheck = 0;
                return;
            }
        }
        if (checkeventtime == 4)
        {
            timecheck = 1f * Time.deltaTime + timecheck;
            if (timecheck >= 1)
            {
                BLACKBGWALL.SetActive(false);
                EYEWALL.SetActive(false);
                checkevent2 = 2;
                timecheck = 0;
                return;
            }
        }




    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (checkevent == 1)
            {
                EYEWALL.SetActive(true);
                BLACKBGWALL.SetActive(true);
                checkeventtime = 2;
                return;

            }
            if (checkevent3 == 1)
            {
                if (Input.GetKeyDown("e"))
                {
                    {
                        CHAT.NumberChat = 25;
                        Textbox.SetActive(true);
                        Textchar.SetActive(true);
                        BGBLACK.SetActive(true);
                        FaceStart.SetActive(true);
                        CHAT.checkinputpp = 1;
                        MOveCilck.checkmove = 0;

                    }
                }
            }


        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (checkevent2 == 1)
        {
            audioSource1.SetActive(true);
            audioSource.PlayOneShot(dIED);
            EVEWALLANIMATION.checkevent = 2;
            checkeventtime = 3;
            return;
        }
    }
}
