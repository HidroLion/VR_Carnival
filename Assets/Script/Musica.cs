using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    [SerializeField] AudioClip[] canciones;
    AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        source.clip = canciones[0];
    }

    public void MusicaVictoria()
    {
        source.Stop();
        source.clip = canciones[1];
        source.Play();
    }
}
