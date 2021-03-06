﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadioSound : MonoBehaviour {

    public Slider backVolume;
    public AudioSource audio;

    private float backVol = 1f;

	// Use this for initialization
	private void Start () {
        backVol = PlayerPrefs.GetFloat("backvol", 1f);
        backVolume.value = backVol;
        audio.volume = backVolume.value;
	}
	
	// Update is called once per frame
	void Update () {
        SoundSlider();
	}

    public void SoundSlider()
    {
        audio.volume = backVolume.value;

        backVol = backVolume.value;
        PlayerPrefs.SetFloat("backvol", backVol);
    }
}
