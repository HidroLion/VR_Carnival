using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMoviles : MonoBehaviour
{
    [SerializeField] Transform[] positions;
    [SerializeField] public float velocidad;
    [SerializeField] public float velocidadI;
    bool ocilador;
    public Menus play;

    private void Start()
    {
        ocilador = true;
    }

    void Update()
    {
        if(play.jugar)
        {
            velocidad = velocidadI;
            if (ocilador)
            {
                transform.position = Vector3.MoveTowards(transform.position, positions[0].position, velocidad);

                if (transform.position == positions[0].position)
                    ocilador = false;
            }

            if (!ocilador)
            {
                transform.position = Vector3.MoveTowards(transform.position, positions[1].position, velocidad);

                if (transform.position == positions[1].position)
                    ocilador = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, positions[1].position, 0.03f);
            if (transform.position == positions[1].position && play.active)
            {
                play.juega.SetActive(true);
                //play.p.SetActive(true);
                velocidad = 0f;
                play.active = false;
            }
        }
        
    }
}
