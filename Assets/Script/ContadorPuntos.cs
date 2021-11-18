using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorPuntos : MonoBehaviour
{
    [SerializeField] int puntajeMaximo;
    [SerializeField] ParticleSystem[] particles;
    int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
    }

    private void Update()
    {
        if(puntaje == puntajeMaximo)
        {
            Victoria();
        }

#if UNITY_EDITOR
        if (Input.GetButtonDown("Jump"))
        {
            Victoria();
        }
#endif
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Objetivo"))
        {
            puntaje += 1;
        }
    }

    void Victoria()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            particles[i].Play();
        }
    }
}
