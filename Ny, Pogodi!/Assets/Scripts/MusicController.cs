using System.Collections;
using UnityEngine.Audio;
using UnityEngine;

public class MusicController : MonoBehaviour {

    public AudioClip[] stings = new AudioClip[5];

    private AudioSource _audioSource; 
    private int _prevMusic;

    private void StartRandomMusic()
    {
        int randClip;
        while (true)
        {
            randClip = Random.Range(0, stings.Length);
            if (randClip != _prevMusic)
            {
                _prevMusic = randClip;
                break;
            }
        }
        _audioSource.clip = stings[randClip];
        _audioSource.Play();
    }

    private void Start () {
        _audioSource = transform.GetComponent<AudioSource>();
        _prevMusic = -1;
        StartRandomMusic();
    }

    private void Update()
    {
        if (!_audioSource.isPlaying)
        {
            StartRandomMusic();
        }
    }
}
