using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip[] sound;
    public AudioSource a;
    public void SoundPlay1()
    {
        a.clip = sound[0];
        a.Play();
    }
    public void SoundPlay2()
    {
        a.clip = sound[1];
        a.Play();
    }
    public void SoundPlay3()
    {
        a.clip = sound[2];
        a.Play();
    }
    public void SoundPlay4()
    {
        a.clip = sound[3];
        a.Play();
    }
}
