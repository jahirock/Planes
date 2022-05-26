using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instace;

    AudioSource audioSource;
    public AudioClip shoot;

    private void Awake()
    {
        if(instace != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instace = this;
        }

        audioSource = GetComponent<AudioSource>();

        DontDestroyOnLoad(gameObject);
    }

    public void PlayShoot()
    {
        audioSource.PlayOneShot(shoot);
    }

}
