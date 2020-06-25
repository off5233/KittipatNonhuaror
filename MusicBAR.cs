using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicBAR : MonoBehaviour
{
    public Slider MusicbarBG;
    public Slider MusicbarEFF;
    public static float MusicsBG;
    public static float MusicsEFF;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        MusicsBG = MusicbarBG.value;
        MusicsEFF = MusicbarEFF.value;
        MUSICBARIN.MusicsBGIN = MusicsBG;
        MUSICBARIN.MusicsEFFIN = MusicsEFF;
    }
}
