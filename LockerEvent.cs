using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerEvent : MonoBehaviour
{
    public GameObject EYEWALL;
    public GameObject BLACKBGWALL;
    [SerializeField]
    Animator chestAnimator;
    int checkpointlight = 1;
    int checkevent = 1;
    int checkevent2 = 1;
    float timecheck = 0;
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
                EYEWALL.SetActive(true);
                BLACKBGWALL.SetActive(true);
                timecheck = 1f * Time.deltaTime + timecheck;
                return;
            }
            if(timecheck >= 1)
            {
                checkevent = 2;
                BLACKBGWALL.SetActive(false);
                timecheck = 0;
                return;
            }


        }

    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (checkevent2 == 1)
        {
            chestAnimator.SetBool("checkwallplayer", true);
            BLACKBGWALL.SetActive(true);
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
}
