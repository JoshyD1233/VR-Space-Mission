using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusicOnTrigger : MonoBehaviour
{
    public AudioSource musicSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }
}