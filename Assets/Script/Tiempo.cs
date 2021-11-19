using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiempo : MonoBehaviour
{
    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        tiempo = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        ActivarTiempo();
        Debug.Log(ActivarTiempo());
    }
    public float ActivarTiempo()
    {
        return tiempo -= Time.deltaTime;
    }
}
