using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPointS1 : MonoBehaviour
{
    public GameObject EYE;
    public GameObject BGBRED;
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
    int checkcodeinput = 0;
    int checkTIME = 1;
    float timestarts1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerExit2D(Collider2D other)
    {
        EYE.SetActive(false);
        BGBRED.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        
    if (other.gameObject.name == "player")
        {
            if (checkTIME == 1)
        {
            if (timestarts1 <= 1)
            {
               EYE.SetActive(true);
               BGBRED.SetActive(true);
                timestarts1 = 0.45f * Time.deltaTime + timestarts1;
                
                    if(timestarts1 >= 1)
                    {
                        checkTIME = 2;
                        return;
                    }
            }
        }

        if (checkTIME == 2) 
            {
            
                if (checkcodeinput == 0)
                {
                    {

                        CHAT.NumberChat = 20;
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
