using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterEvent : MonoBehaviour
{
    public AudioClip GROW;
    public AudioSource audioSource;
    public GameObject audioSource1;


    public GameObject Monster;
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

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            if (checkevent == 1)
            {
                {
                    audioSource1.SetActive(true);
                    audioSource.PlayOneShot(GROW);
                    CHAT.NumberChat = 28;
                    Monster.SetActive(true);
                    Textbox.SetActive(true);
                    Textchar.SetActive(true);
                    BGBLACK.SetActive(true);
                    FaceStart.SetActive(true);
                    CHAT.checkinputpp = 1;
                    MOveCilck.checkmove = 0;
                    checkevent = 2;
                    return;

                }
            }

        }
    }
}
