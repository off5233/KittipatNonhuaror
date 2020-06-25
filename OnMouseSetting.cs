using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseSetting : MonoBehaviour
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
        chestAnimator.SetBool("S", true);
    }
    void OnMouseExit()
    {
        chestAnimator.SetBool("S", false);
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("option menu");
    }
}
