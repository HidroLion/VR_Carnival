using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{
    public float tiempo;
    public Menus play;
    public bool time;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        tiempo = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        if(time)
        {
            tiempo = 60f;
            time = false;
        }
        if(play.jugar)
        {
            ActivarTiempo();
            DisplayTime(tiempo);
            if(tiempo<=0f)
            {
                tiempo = 0f;
                play.jugar = false;
                play.active = true;
            }
        }

        //Debug.Log(ActivarTiempo());
    }
    public float ActivarTiempo()
    {
        return tiempo -= Time.deltaTime;
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
