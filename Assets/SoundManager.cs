using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    //이거 이제 안씀

    public AudioSource audioSource;
    public AudioSource SESource;
    [SerializeField] AudioClip[] audioclip;
    public void SetMusicVolume(float volume)
    {
        audioSource.volume = volume;
    }
    public void SetSEVolume(float volume)
    {
        SESource.volume = volume;
    }

}

