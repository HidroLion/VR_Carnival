using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

namespace BNG
{
    public class ContadorPuntos : MonoBehaviour
    {
        [SerializeField] int puntajeMaximo;
        [SerializeField] ParticleSystem[] particles;
        [SerializeField] Musica parlantes;
        [SerializeField] Text puntosText;
        [SerializeField] PlataformasMoviles plat;
        public int puntaje;
        public Tiempo t;
        public Grabbable g;
        public Menus play;

        private void Update()
        {
            if(play.jugar)
            {
                if(t.tiempo>=59)
                {
                    puntaje = 0;
                }
                g.enabled = true;
                DisplayPuntos(puntaje);
            }
            else
            {
                g.enabled = false;
                DisplayPuntos(puntaje);
            }
            if(t.tiempo<=0f)
            {
                for (int i = 0; i < particles.Length; i++)
                {
                    particles[i].Play();
                }
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
        }

        public void SumarPunto()
        {
            puntaje += 20;
        }
        public void RestarPunto()
        {
            puntaje -= 10;
            t.tiempo -= 5f;
        }
        void DisplayPuntos(int puntosToDisplay)
        {
            puntosText.text = "Puntos: " + puntosToDisplay;
        }
    }

}

