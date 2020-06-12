using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTriger : MonoBehaviour
{   public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
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
            if (Input.GetKeyDown("e"))
            {
                {
                    CHAT.NumberChat = 5;
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
