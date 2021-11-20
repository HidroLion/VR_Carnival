using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{
    [SerializeField] AudioClip[] canciones;
    [SerializeField] AudioSource[] source;

    void Start()
    {
        source[0].clip = canciones[0];
        source[0].Play();

        source[1].clip = canciones[1];
        source[1].Stop();
    }

    public void MusicaVictoria()
    {
        source[0].Stop();
        source[1].Play();
    }
}
