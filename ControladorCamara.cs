using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCamara : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    float alturaPlayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        alturaPlayer = player.transform.position.y;
        float alturaCamara = this.transform.position.y;
        float alturaCamaraActualizada = Mathf.Lerp(alturaCamara, alturaPlayer, Time.deltaTime * 10);

        if (alturaPlayer > alturaCamara)
        {
            this.transform.position = new Vector3(this.transform.position.x, alturaCamaraActualizada, this.transform.position.z);
        }
        else if (alturaPlayer<alturaCamaraActualizada -5.5f) //el -5.5f se puede editar para que se reinicie la escena
        {
            Puntuaciones.puntuacion.verificarPuntajeMaximo();
            SceneManager.LoadScene("Mundo1");
        }

        if (alturaPlayer > Puntuaciones.puntaje)
        {
            Puntuaciones.puntaje = (int)alturaPlayer;
        }
    }
}
