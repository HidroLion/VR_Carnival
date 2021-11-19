using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBloques : MonoBehaviour
{
    [SerializeField] ContadorPuntos contador;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            contador.SumarPunto();
            Explotar();
        }
    }

    void Explotar()
    {

    }
}
