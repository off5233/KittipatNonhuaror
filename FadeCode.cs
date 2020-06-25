using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeCode : MonoBehaviour
{
    public static int checkEvent1 = 0;
    public Animator AnimatorFade;
    public Animator AnimatorFadeStestCode;

    // Start is called before the first frame update
    public void Fade()
    {
        AnimatorFade.SetBool("CheckEvent", false);
        SceneManager.LoadScene("Title");

    }

    public void FadeINDIED()
    {
        if (checkEvent1 == 0)
        {
            AnimatorFadeStestCode.SetBool("FadeCheck", false);
            SceneManager.LoadScene("DIED");
        }
        if (checkEvent1 == 1)
        {
            AnimatorFadeStestCode.SetBool("FadeCheck", false);
            SceneManager.LoadScene("TobeCou");
            checkEvent1 = 0;
            return;

        }


    }


}
