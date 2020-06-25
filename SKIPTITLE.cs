using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SKIPTITLE : MonoBehaviour
{
    public GameObject SKIPBAR;
    public GameObject TEXTSKIP;
    public Slider Skipbar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SKIPBAR.SetActive(true);
            TEXTSKIP.SetActive(true);
            Skipbar.value += 3 * Time.deltaTime;
            if(Skipbar.value >= 10)
            {
                SceneManager.LoadScene("TestCode");
            }
        }
        else 
        {
            Skipbar.value = 0;
            SKIPBAR.SetActive(false);
            TEXTSKIP.SetActive(false);
        }
    }
}
