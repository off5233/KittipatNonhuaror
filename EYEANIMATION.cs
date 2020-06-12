using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EYEANIMATION : MonoBehaviour
{
    [SerializeField]
    Animator EYEchestAnimator;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EYEchestAnimator.SetBool("EYESHOW", true);
    }
}
