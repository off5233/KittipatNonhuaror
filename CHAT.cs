using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHAT : MonoBehaviour
{

    public GameObject playerface3;
    public GameObject playerface2;
    public GameObject playerface2_1;
    public GameObject playerface1;
    public GameObject BGBRED;
    public GameObject BGBLACK;
    public GameObject Textbox;
    public GameObject Textchar;
    [SerializeField] Text text;
    public static int NumberChat = 0;
    public static int checkinputpp = 0;
    void Start()
    {

    }

    void Update()
    {
        //S1 START
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            if(checkinputpp == 1 )
            {
                NumberChat = NumberChat+1;
                return;
            }
        }

        if (NumberChat == 1)
        {
            text.text = "...อ๊ะ...";
        }
        if (NumberChat == 2)
        {
            text.text = "...เอ๋...";
            playerface3.SetActive(false);
            playerface2_1.SetActive(true);
        }
        if (NumberChat == 3)
        {
            text.text = "...ที่นี่มันคือที่ไหนกัน...";
            playerface2.SetActive(true);
            playerface2_1.SetActive(false);
        }
        if (NumberChat == 4)
        {
            playerface2.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            return;

        }


        //TestPIC2
        if (NumberChat == 5)
        {
            text.text = " ..นี่มันเหมือนกับรูปวาดครอบครัวเลยแฮะ... ";
            return;

        }
        if (NumberChat == 6)
        {
            text.text = " ..แต่ว่า..มันค่อนข้างเก่าเลย..... ";
            playerface1.SetActive(false);
            playerface2_1.SetActive(true);
            return;
        }
        if (NumberChat == 7)
        {
            text.text = "..ทิ้งไว้นี่ละกัน..";
            playerface2_1.SetActive(false);
            playerface1.SetActive(true);
            return;
        }
        if (NumberChat == 8)
        {
            playerface1.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 2;
            return;

        }

        //TestPic2
        if (NumberChat == 9)
        {
            text.text = "!!!!";
            return;

        }
        if (NumberChat == 10)
        {
            text.text = " ..ท..ทำไม..รูปถึงเปลื่ยนไปล่ะ.. ";
            playerface2.SetActive(false);
            playerface2_1.SetActive(true);
            return;
        }
        if (NumberChat == 11)
        {
            text.text = "รีบๆออกจากที่นี่ดีกว่า";
            playerface2_1.SetActive(false);
            playerface3.SetActive(true);
            return;
        }
        if (NumberChat == 12)
        {
            BGBRED.SetActive(false);
            playerface3.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }

        //Looker
        if (NumberChat == 13)
        {
            text.text = "รู้สึกว่าจะเป็นรูปอะไรสักอย่างแฮะ...";
            return;

        }
        if (NumberChat == 14)
        {
            text.text = " ..เอ๋..มีไรอยู่ข้างหลังด้วย.. ";
            return;
        }
        if (NumberChat == 15)
        {
            text.text = " [ กด Q เพื่อเปืดเมนูไอเทม ] ";
            return;
        }
        if (NumberChat == 16)
        {
            playerface1.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }

        //SaveZone?
        if (NumberChat == 17)
        {
            text.text = "..มองอะไรไม่เห็นเลย....";
            return;

        }
        if (NumberChat == 18)
        {
            text.text = " ..ไม่เดินเข้าไปดีกว่าแฮะ.... ";
            playerface2_1.SetActive(false);
            playerface3.SetActive(true);
            return;
        }
        if (NumberChat == 19)
        {
            playerface3.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }

        //Point1
        if (NumberChat == 20)
        {
            text.text = "...รู้สึกเหมือนมีอะไรจ้องมองอยู่เลยแฮะ....";
            return;

        }
        if (NumberChat == 21)
        {
            text.text = " ..ทางออกอยู่ไหนกันนะ.... ";
            playerface2.SetActive(false);
            playerface2_1.SetActive(true);
            return;
        }
        if (NumberChat == 22)
        {
            playerface2_1.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }


    }
}
