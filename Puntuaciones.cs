using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Puntuaciones : MonoBehaviour
{
    // Start is called before the first frame update
    public static Puntuaciones puntuacion;
    public static int puntaje;

    int puntajeMaximo;

    Text textoPuntaje;
    Text textoPuntajeMax;
    void Start()
    {
        puntuacion = this;
        puntaje = 0;
        puntajeMaximo = PlayerPrefs.GetInt("puntajeMaximo", 0);
        textoPuntaje = GameObject.Find("Texto_Puntaje").GetComponent<Text>();
        textoPuntajeMax = GameObject.Find("Texto_PuntajeMax").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textoPuntaje.text = "Puntaje: " + puntaje;
        textoPuntajeMax.text = "Puntaje Máximo: " + puntajeMaximo;
        
    }
    public void verificarPuntajeMaximo()
    {
        if (puntaje>puntajeMaximo)
        {
            PlayerPrefs.SetInt("puntajeMaximo", puntaje);
        }
    }
}
