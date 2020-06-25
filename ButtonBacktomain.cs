using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonBacktomain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BACKmainmenu()
    {
        MOveCilck.checkmove = 1;
        MOveCilck.timestarts1 = 0;
        Looker.getitem = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Clarity");
    }
}
