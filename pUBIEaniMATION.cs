using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pUBIEaniMATION : MonoBehaviour
{
    public Animator Animaation;
    public GameObject gAME;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AnimationOUT()
    {
        gAME.SetActive(false);
    }
    public void RunfIN()
    {

    }
    public void RunfoIN()
    {
        SceneManager.LoadScene("End");
    }
}
