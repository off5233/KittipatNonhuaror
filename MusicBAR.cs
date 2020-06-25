using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Musicbar : MonoBehaviour
{
    public Slider MusicbarBG;
    public Slider MusicbarEFF;
    public static float NumberMusicbarBG;
    public static float NumberMusicbarEFF;

    void Start()
    {
        
    }

    void Update()
    {
        NumberMusicbarBG = MusicbarBG.value;
        MusicSound.MusicsBG = NumberMusicbarBG;
        NumberMusicbarEFF = MusicbarEFF.value;
    }
}
