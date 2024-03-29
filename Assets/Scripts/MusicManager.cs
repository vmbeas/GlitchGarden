﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;

    private AudioSource audioSource;

	// Use this for initialization
	void Awake () {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't destroy on load: " + name);
	}

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnLevelWasLoaded(int level) {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip: " + thisLevelMusic);

        if (thisLevelMusic && thisLevelMusic != audioSource.clip) { // If there's some music attached
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void SetVolume(float customVolume) {
        audioSource.volume = customVolume;
    }
}
