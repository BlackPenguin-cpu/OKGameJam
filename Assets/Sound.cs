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
    override protected void init() { }

    public void ChangeClip(string name, bool loop)
    //���� Sound.Instance.ChangeClip("�̸�",���� �Ҳ������Ҳ���(bool))
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
}
