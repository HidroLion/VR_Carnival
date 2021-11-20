using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    [SerializeField] AudioClip[] canciones;
    [SerializeField] AudioSource[] sources;

    void Start()
    {
        sources[0].clip = canciones[0];
        sources[1].clip = canciones[1];
    }

    public void MusicaVictoria()
    {
        sources[0].Stop();
        sources[1].Play();
    }
}
