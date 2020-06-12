using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseSave : MonoBehaviour
{
    [SerializeField]
    Animator chestAnimator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseOver()
    {
        chestAnimator.SetBool("b", true);
    }
    void OnMouseExit()
    {
        chestAnimator.SetBool("b", false);
    }
}
