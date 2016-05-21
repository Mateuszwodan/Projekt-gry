using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class volume_controller : MonoBehaviour {

    public float volume = 0.5f;

    public Slider volume_slider;

    private AudioSource[] audios;

    private bool if_music_play = true;

    void Start()
    {
        audios = GetComponentsInChildren<AudioSource>();
    }


    void Update()
    {
        ChangeVolume();

        if (Input.GetKeyDown(KeyCode.M))
        {
            TurnOnOrOffMusic();
        }

    }

    public void TurnOnOrOffMusic()
    {
        if (!if_music_play)
        {
            audios[0].Play();
            if_music_play = true;
        }
        else if (if_music_play)
        {
            audios[0].Pause();
            if_music_play = false;
        }
    }

    public void ChangeVolume()
    {
        volume = volume_slider.value;
        audios[0].volume = volume;
        audios[1].volume = volume;
    }
}