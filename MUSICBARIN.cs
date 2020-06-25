using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MUSICBARIN : MonoBehaviour
{
    public AudioSource MusicbarBGIN;
    public AudioSource MusicbarEFFIN;
    public static float MusicsBGIN = 1;
    public static float MusicsEFFIN = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MusicbarBGIN.volume = MusicsBGIN;
        MusicbarEFFIN.volume = MusicsEFFIN;
    }
}
