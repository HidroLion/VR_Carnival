using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorPuntos : MonoBehaviour
{
    [SerializeField] int puntajeMaximo;
    [SerializeField] ParticleSystem[] particles;
    [SerializeField] Musica parlantes;
    [SerializeField] Text victoriaText;
    int puntaje;

    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
        victoriaText.text = " ";
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

    void Victoria()
    {
        for (int i = 0; i < particles.Length; i++)
        {
            particles[i].Play();
        }

        parlantes.MusicaVictoria();
        victoriaText.text = "¡Has Ganado!";
    }

    public void SumarPunto()
    {
        puntaje++;
    }
}
