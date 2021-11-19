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
        [SerializeField] Text victoriaText;
        [SerializeField] PlataformasMoviles plat;
        public int puntaje;
        public Tiempo t;
        public Grabbable g;


        // Start is called before the first frame update
        void Start()
        {
            puntaje = 0;
            //victoriaText.text = " ";
        }

        private void Update()
        {
            //Debug.Log(puntaje);
            /*if(puntaje == puntajeMaximo)
            {
                Victoria();
            }*/
            if (t.tiempo <= 0f)
            {
                plat.velocidad = 0f;
                g.enabled = false;
                Victoria();
            }
            else
            {
                plat.velocidad = plat.velocidadI;
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

            //parlantes.MusicaVictoria();
            //victoriaText.text = "¡Has Ganado!";
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

