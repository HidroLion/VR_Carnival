using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformasMoviles : MonoBehaviour
{
    [SerializeField] Transform[] positions;
    [SerializeField] float velocidad;
    bool ocilador;

    private void Start()
    {
        ocilador = true;
    }

    void Update()
    {
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
}
