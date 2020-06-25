using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPiano : MonoBehaviour

{ 
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    public GameObject FaceStart;
    int checkevent = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (checkevent == 1)
            {
                {
                    CHAT1.NumberChat = 1;
                    Textbox.SetActive(true);
                    Textchar.SetActive(true);
                    BGBLACK.SetActive(true);
                    FaceStart.SetActive(true);
                    CHAT1.checkinputpp = 1;
                    MovePlayer3d.checkmove = 0;
                    checkevent = 2;
                    return;

                }
            }

        }
    }
}
