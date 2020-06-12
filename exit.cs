using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Animator chestAnimator;
    void Start()
    {

    }

    void Update()
    {

    }

    void OnMouseOver()
    {
        chestAnimator.SetBool("c", true);
    }
    void OnMouseExit()
    {
        chestAnimator.SetBool("c", false);
    }
    void OnMouseDown()
    {
        Application.Quit();
    }

}
