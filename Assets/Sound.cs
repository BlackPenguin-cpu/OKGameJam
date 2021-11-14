using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Clip
{
    public string Name;
    public AudioClip clip;
}
public class Sound : Singleton<Sound>
{
    public AudioSource audioSource;
    public AudioSource audioSE;
    public List<Clip> clips = new List<Clip>();
    public Sound() { }

    public void ChangeClip(string name, bool loop)
    //사용법 Sound.Instance.ChangeClip("이름",루프 할껀지안할껀지(bool))
    {
        Clip find = clips.Find((o) => { return o.Name == name; });
        if (find != null)
        {
            if (loop == true)
            {
                audioSource.Stop();
                audioSource.clip = find.clip;
                audioSource.loop = false;
                audioSource.Play();
            }
            else if (loop == false)
            {
                audioSE.clip = find.clip;
                audioSE.loop = false;
                audioSE.Play();

            }
        }
    }
    public void SetMusicVolume(float volume)
    {
        audioSource.volume = volume;
    }
    public void SetSEVolume(float volume)
    {
        audioSE.volume = volume;
    }
}
