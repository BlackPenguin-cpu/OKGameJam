using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    //�̰� ���� �Ⱦ�

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

