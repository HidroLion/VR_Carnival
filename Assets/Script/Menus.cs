using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    public bool jugar;
    public bool active;
    //spublic GameObject p;
    public GameObject controles;
    public GameObject juega;
    public Tiempo t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Play()
    {
        t.time = true;
        juega.SetActive(false);
        //p.SetActive(false);
        Debug.Log("Play");
        jugar = true;
    }
    public void Instrucciones()
    {
        controles.SetActive(true);
        juega.SetActive(false);
        //p.SetActive(false);
        Debug.Log("Instucciones");
    }
    public void Volver()
    {
        controles.SetActive(false);
        juega.SetActive(true);
        //p.SetActive(true);
        Debug.Log("Vuelve");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
