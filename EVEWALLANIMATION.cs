using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EVEWALLANIMATION : MonoBehaviour
{
    [SerializeField]
    Animator chestAnimator;
    public static int checkevent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(checkevent == 2)
        {
            chestAnimator.SetBool("checkwallplayer", true);
            checkevent = 1;
            return;

        }
        
    }
}

