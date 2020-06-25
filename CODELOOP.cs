using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CODELOOP : MonoBehaviour
{
    public GameObject playerWarp;
    public Animator BG;
    public Animator AnimaationText;
    public Text CAHT1;
    int NumberRun = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.name == "fall1")
        {
            playerWarp.transform.position = new Vector3(0, 0, 0);
        }
    }

    public void CodeRunEvent()
    {
        BG.SetBool("CheckEvent", false);
        AnimaationText.SetBool("EventStart", true);
    }

    public void CodeEventCHAT()
    {
        if (NumberRun != 6)
        {
            NumberRun = NumberRun + 1;
            AnimaationText.SetBool("EventFade", true);
            return;
        }
        if (NumberRun == 5)
        {

            NumberRun = 0;
            SceneManager.LoadScene("MAP1");
            return;
        }

    }
    public void FadeOut()
    {
        if (NumberRun == 0)
        {
            CAHT1.text = "..ทำไมเจ้าถึงมาอยู่ที่นี้อย่างงั้นหรือ?..";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 1)
        {
            CAHT1.text = "คำตอบนั้นเจ้าต้องเป็นคนตามหาเอง";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 2)
        {
            CAHT1.text = "..ทั้งความทรงจำ..";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 3)
        {
            CAHT1.text = "..และ..";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 4)
        {
            CAHT1.text = "..ชื่อของเจ้าด้วย..";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 5)
        {

            NumberRun = 0;
            SceneManager.LoadScene("MAP1");
            return;
        }
    }


    public void CodeEventCHATMap2()
    {
        if (NumberRun != 5)
        {
            NumberRun = NumberRun + 1;
            AnimaationText.SetBool("EventFade", true);
            return;
        }
    }

    public void FadeOutMap1()
    {
        if (NumberRun == 0)
        {
            CAHT1.text = "คุณพ่อคุณแม่";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 1)
        {
            CAHT1.text = " วันนี้เราจะไปไหนกันเหรอค่ะ? ";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 2)
        {
            CAHT1.text = "...";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 3)
        {
            CAHT1.text = " Orchestra? ";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 4)
        {
            CAHT1.text = " มันคืออะไรเหรอค่ะ? ";
            AnimaationText.SetBool("EventFade", false);
        }
        if (NumberRun == 5)
        {
            MovePlayer3d.checkmove = 2;
            playerWarp.SetActive(false);
            NumberRun = 0;
            return;
        }
    }
    
    public void BLackbgmemory()
    {

        playerWarp.SetActive(true) ;
    }

    public void NextScenc()
    {

        SceneManager.LoadScene("Scene1");
    }


}
