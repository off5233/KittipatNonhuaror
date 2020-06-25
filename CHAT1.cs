using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CHAT1 : MonoBehaviour
{
    public Animator FadeEvent;
    public Animator FadeEventMap1;
    public GameObject map1;
    public GameObject textmap1;

    public GameObject StrBar;
    public GameObject CameraPlayer;
    public GameObject playerface3;
    public GameObject playerface2;
    public GameObject playerface2_1;
    public GameObject playerface1;
    public GameObject BGBRED;
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject BGBLACKALL;
    public GameObject Textchar;
    [SerializeField] Text text;

    public GameObject TextcharMomster;
    public Text textmonster;

    public static int NumberChat = 0;
    public static int checkinputpp = 0;
    public static int item = 0;

    void Start()
    {

    }

    void Update()
    {
        //S1 START
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            if (checkinputpp == 1)
            {
                NumberChat = NumberChat + 1;
                return;
            }
        }
        if (item == 1)
        {

            if (NumberChat == 1)
            {
                StrBar.SetActive(false);
                text.text = "..ร..รู้สึกปวดหัวจัง..";
            }
            if (NumberChat == 2)
            {
                map1.SetActive(true) ;
                FadeEventMap1.SetBool("CheckEvent", true);
                playerface2.SetActive(false);
                Textbox.SetActive(false);
                Textchar.SetActive(false);
                BGBLACK.SetActive(false);
                checkinputpp = 0;
                NumberChat = 0;
                item =  3;
                return;

            }
        }

        if (item == 0)
        {

            if (NumberChat == 1)
            {
                StrBar.SetActive(false);
                text.text = "..ทำไมถึงรู้สึกคุ้นๆกับที่นี่เลยแฮะ...";
            }
            if (NumberChat == 2)
            {
                text.text = "[ เนื่องจากคุณไม่มีคีย์ไอเทม ]";
            }
            if (NumberChat == 3)
            {

                MovePlayer3d.checkmove = 2;
                playerface2.SetActive(false);
                Textbox.SetActive(false);
                Textchar.SetActive(false);
                BGBLACK.SetActive(false);
                checkinputpp = 0;
                NumberChat = 0;
                item = 3;
                return;

            }
        }

    }
}
