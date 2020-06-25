using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHARDIED : MonoBehaviour
{
    public GameObject Textchar;
    [SerializeField] Text text;
    public GameObject BbackGame;
    public GameObject Bmainmanu;
   
    public static int NumberChat = 1;
    public static int checkinputpp = 1;
    public static int Numberdied = 0;
    public static int checkeventrun = 1;
    public static int NumberdiedMON = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            if (checkinputpp == 1)
            {
                NumberChat = NumberChat + 1;
                return;
            }
        }


        if (checkeventrun == 1)
        {
            if (Numberdied == 4)
            {
                if (NumberChat == 1)
                {
                    text.text = " ..ทำไมเจ้านั้นถึง..มาอยู่ที่นี้ได้...";
                }
                if (NumberChat == 2)
                {
                    text.text = "..ช่างมันเถอะ..ไม่มีอะไร....";
                    BbackGame.SetActive(true);
                    Bmainmanu.SetActive(true);
                    Numberdied = 0;
                    NumberdiedMON = 0;
                    checkinputpp = 0;
                    NumberChat = 1;
                    checkeventrun = 0;
                    return;
                }
            }

                if (Numberdied == 1)
            {
                if (NumberChat == 1)
                {
                    text.text = "..น่าสงสารจริงๆ..";
                }
                if (NumberChat == 2)
                {
                    text.text = "..ที่ตายแบบไม่รู้ตัว..";
                }
                if (NumberChat == 3)
                {
                    text.text = "..แต่..ใครสอนให้เข้าไปที่มืดกันล่ะ..";
                }
                if (NumberChat == 4)
                {
                    text.text = "..ข้าจะให้โอกาสเจ้าอีกครั้งละกัน..\n...หวังว่าข้าคงไม่เห็นเจ้าที่นี่อีก..";
                    BbackGame.SetActive(true);
                    Bmainmanu.SetActive(true);
                    checkinputpp = 0;
                    NumberChat = 1;
                    checkeventrun = 0;
                    return;
                }
            }

            if (Numberdied == 2)
            {
                if (NumberChat == 1)
                {
                    text.text = ".....";
                }
                if (NumberChat == 2)
                {
                    text.text = "..เฮ้อ...";
                }
                if (NumberChat == 3)
                {
                    text.text = "..ทำบ้าอะไรของเจ้านะ..เด็กสาว....";
                }
                if (NumberChat == 4)
                {
                    text.text = "..ถ้าเจ้ายัง 'จงใจ' เข้าไปที่นั้นอีก\n....ข้าคงต้องสอนบทเรียนกับเจ้า....";
                    BbackGame.SetActive(true);
                    Bmainmanu.SetActive(true);
                    checkinputpp = 0;
                    NumberChat = 1;
                    checkeventrun = 0;
                    return;
                }
            }

            if (Numberdied == 3)
            {
                if (NumberChat == 1)
                {
                    text.text = ".....";
                }
                if (NumberChat == 2)
                {
                    text.text = "..พอกันที..";
                }
                if (NumberChat == 3)
                {
                    text.text = "..ข้า..จะไม่ให้โอกาสเจ้าอีกแล้ว...";
                }
                if (NumberChat == 4)
                {
                    text.text = "..ลาก่อน...เจ้าเด็กน้อย...";


                }
                if (NumberChat == 5)
                {
                    Application.Quit();
                    checkinputpp = 0;
                    NumberChat = 1;
                    checkeventrun = 0;
                    return;
                }





            }
        }
    }

}
