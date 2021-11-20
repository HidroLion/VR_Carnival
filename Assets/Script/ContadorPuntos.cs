using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

namespace BNG
{
    public class ContadorPuntos : MonoBehaviour
    {
        [SerializeField] ParticleSystem[] particles;
        [SerializeField] Musica parlantes;
        [SerializeField] PlataformasMoviles[] plat;

        public int puntaje;
        public Tiempo t;
        public Grabbable g;


        // Start is called before the first frame update
        void Start()
        {
            puntaje = 0;
        }

        private void Update()
        {
            if (t.tiempo <= 0f)
            {
                for (int i = 0; i < plat.Length; i++)
                {
                    plat[i].velocidad = 0f;
                }

                g.enabled = false;
                Victoria();
            }
            else
            {
                for (int i = 0; i < plat.Length; i++)
                {
                    plat[i].velocidad = plat[i].velocidadI;
                }

                g.enabled = true;
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
    }

}

