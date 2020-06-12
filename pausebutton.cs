using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pausebutton : MonoBehaviour
{
    public GameObject pasuebutton;
    public GameObject Return;
    public GameObject MainMenu;
    public GameObject Restart;
    public GameObject Quit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
            Time.timeScale = 0;
            pasuebutton.SetActive(false);
            Return.SetActive(true);
            MainMenu.SetActive(true);
            Restart.SetActive(true);
            Quit.SetActive(true);


    }
}
