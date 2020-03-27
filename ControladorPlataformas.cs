using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPlataformas : MonoBehaviour
{
    public Transform plataformaNormal;
    public Transform plataformaMovimiento;
    public Transform plataformaMegaSalto;
    public Transform plataformaDesaparece;

    int numeroDePlataforma;
    public Transform player;
    float alturaPlayer;
    float verificadorPlataformas;
    float generarPlataformas;
    // Start is called before the first frame update
    void Start()
    {
        GeneradorPlataformas(-2);
    }

    // Update is called once per frame
    void Update()
    {
        alturaPlayer = player.transform.position.y;
        if (alturaPlayer>verificadorPlataformas)
        {
            PlataformasManejador();
        }
    }
    void PlataformasManejador()
    {
        verificadorPlataformas = player.transform.position.y + 15;
        GeneradorPlataformas(verificadorPlataformas + 15);
    }

    void GeneradorPlataformas( float valorDeFloat)
    {
        float y = generarPlataformas;
        while (y<=valorDeFloat)
        {
            float x = Random.Range(-11, 8);
            numeroDePlataforma = Random.Range(1, 5);
            Vector2 posicionEnXyY = new Vector2(x, y);

            if (numeroDePlataforma == 1)
            {
                Instantiate(plataformaNormal, posicionEnXyY, Quaternion.identity);
            }
            if (numeroDePlataforma == 2)
            {
                Instantiate(plataformaMovimiento, posicionEnXyY, Quaternion.identity);
            }
            if (numeroDePlataforma == 3)
            {
                Instantiate(plataformaMegaSalto, posicionEnXyY, Quaternion.identity);
            }
            if (numeroDePlataforma == 4)
            {
                Instantiate(plataformaDesaparece, posicionEnXyY, Quaternion.identity);
            }
            y += Random.Range(0.5f, 3f);
        }
        generarPlataformas = valorDeFloat;
    }
}
