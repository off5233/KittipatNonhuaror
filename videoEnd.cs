﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class videoEnd : MonoBehaviour
{
    // Start is called before the first frame update
        public VideoPlayer vid;

        void Start() { vid.loopPointReached += CheckOver; }

        void CheckOver(UnityEngine.Video.VideoPlayer vp)
        {
        SceneManager.LoadScene("TestCode");
        }
}
