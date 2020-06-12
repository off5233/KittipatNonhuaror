using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMousePlay : MonoBehaviour
{
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
        chestAnimator.SetBool("CheckPlay",true);
    }
    void OnMouseExit()
    {
        chestAnimator.SetBool("CheckPlay", false);
    }
    void OnMouseDown()
    {
        SceneManager.LoadScene("Title");
    }
}
