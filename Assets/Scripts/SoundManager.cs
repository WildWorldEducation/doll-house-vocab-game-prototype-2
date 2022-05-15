using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SoundManager : MonoBehaviour
{
    public static AudioClip fairyHey;
    static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();

        fairyHey = Resources.Load<AudioClip>("Audio/Hey");
    }


    public static void playSound(AudioClip audioclip)
    {
        audioSrc.PlayOneShot(audioclip);
        print("test");
    }
}
