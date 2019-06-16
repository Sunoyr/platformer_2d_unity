using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaylistMusic : MonoBehaviour
{
    Object[] myMusic;

    void Awake()
    {
        myMusic = Resources.LoadAll("Musique", typeof(AudioClip));
        GetComponent<AudioSource>().clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
    }

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<AudioSource>().isPlaying)
        {
            playRandomMusic();
        }
    }

    void playRandomMusic()
    {
        GetComponent<AudioSource>().clip = myMusic[Random.Range(0, myMusic.Length)] as AudioClip;
        GetComponent<AudioSource>().Play();
    }
}
