using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CHAT : MonoBehaviour
{
    public Animator FadeEvent;

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
            StrBar.SetActive(false);
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
            StrBar.SetActive(false);
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
            StrBar.SetActive(false);
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
            StrBar.SetActive(false);
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
            text.text = " [ กด Q เพื่อเปีดเมนูไอเทม ] ";
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
            StrBar.SetActive(false);
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
            StrBar.SetActive(false);
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


        //EyewallEvent
        if (NumberChat == 23)
        {
            StrBar.SetActive(false);
            text.text = "!!!!!";
            return;

        }

        if (NumberChat == 24)
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





        //EyewallEvent
        if (NumberChat == 25)
        {
            StrBar.SetActive(false);
            text.text = "..ดวงตา?..";
            return;

        }
        if (NumberChat == 26)
        {
            text.text = " ..หวังว่าสีแดงนี่..คงไม่ใช่เลือดนะ... ";
            playerface2_1.SetActive(false);
            playerface2.SetActive(true);
            return;
        }
        if (NumberChat == 27)
        {
            playerface2.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }


        //เสียงมอน
        if (NumberChat == 28)
        {
            StrBar.SetActive(false);
            text.text = "..ส..เสียงอะไรนะ..";
            return;

        }
        if (NumberChat == 29)
        {
            RUNEVENTMONSTER.checkrunevent = 2; 
            playerface2.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }

        //มอน
        if (NumberChat == 30)
        {
            textmonster.text = "..มนุษย์..";
            return;
        }
        if (NumberChat == 31)
        {
            textmonster.text = "..ใน.ที่..สุด...ก็..เจอ..";
            return;
        }
        if (NumberChat == 32)
        {
            textmonster.text = "..ยินดี..ต้อนรับ..กลับ...";
            return;
        }
        if (NumberChat == 33)
        {
            Textbox.SetActive(false);
            TextcharMomster.SetActive(false);
            BGBLACK.SetActive(false);
            checkinputpp = 0;
            NumberChat = 0;
            RUNEVENTMONSTER.checkrunevent = 4;
            return;
        }



        //เสียงมอน
        if (NumberChat == 34)
        {
            StrBar.SetActive(false);
            text.text = "..@##$@#$..";
            return;

        }
        if (NumberChat == 35)
        {
            RUNEVENTMONSTER.checkrunevent = 6;
            playerface2.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            MOveCilck.checkmove = 2;
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            return;

        }


        //ประตูล็อค
        if (NumberChat == 36)
        {
            StrBar.SetActive(false);
            text.text = "..เปิดไม่ออก!!..";
            return;

        }
        if (NumberChat == 37)
        {
            text.text = " ..แต่ถ้าออกแรงมันน่าจะพังอออกมาได้นะ.... ";
            return;
        }
        if (NumberChat == 38)
        {
            text.text = " [ กด spawnbar เพื่อพังประตู ]";
            return;
        }
        if (NumberChat == 39)
        {
            playerface2.SetActive(false);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            BGBLACK.SetActive(false);
            checkinputpp = 0;
            NumberChat = 0;
            spawnbarEvent.checkevent1 = 1;
            return;

        }

        
        //
        if (NumberChat == 40)
        {
            StrBar.SetActive(false);
            text.text = " [ หญิงสาวพยายามดันประตู ]";
            return;
        }
        if (NumberChat == 41)
        {
            text.text = " [ จนในที่สุดประตูก็กระเด็นไปตามแรง ]";
            return;

        }
        if (NumberChat == 42)
        {
            text.text = " ..เปิดออกแล้ว!!.. ";
            playerface1.SetActive(true);
            return;
        }
        if (NumberChat == 43)
        {
            text.text = " เอ๋...แต่ไม่มีพื้นนี้!! ";
            playerface1.SetActive(false);
            playerface2.SetActive(true);
            return;
        }
        if (NumberChat == 44)
        {
            text.text = " กรื๊ด------  ";
            playerface2.SetActive(false);
            BGBLACKALL.SetActive(true);
            return;
        }
        if (NumberChat == 45)
        {
            text.text = "[หญิงสาวนั้นร่วงลงไปยังห้อง\nที่มีแต่ความว่างเปล่าและมืดมิด..]";
            BGBLACKALL.SetActive(true);
            return;
        }
        if (NumberChat == 46)
        {
            FadeCode.checkEvent1 = 1;
            BGBLACKALL.SetActive(true);
            Textbox.SetActive(false);
            Textchar.SetActive(false);
            checkinputpp = 0;
            NumberChat = 0;
            codeTestPIC.checkinputE = 3;
            FadeEvent.SetBool("FadeCheck", true);
            return;

        }



    }
}
