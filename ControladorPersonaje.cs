using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{
    public Transform detectorSuelo;
    public bool tocandoSuelo;
    public float fuerzaSalto;
    public float rangoSuelo;
    public LayerMask suelo;

    public float velocidadMovimiento;

    float arribaOAbajo;
    public float fuerzaMegaSalto; //Almacena fuerza MegaSalto
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        arribaOAbajo = GetComponent<Rigidbody2D>().velocity.y;
        float controlHorizontal = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(controlHorizontal* velocidadMovimiento, GetComponent<Rigidbody2D>().velocity.y);

    }

    private void FixedUpdate()
    {
        tocandoSuelo = Physics2D.OverlapCircle(detectorSuelo.position, rangoSuelo,suelo);
        if (tocandoSuelo && arribaOAbajo<=0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            GetComponent<Rigidbody2D>().AddForce (new Vector2(0, fuerzaSalto));
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "MegaSalto" && arribaOAbajo <= 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaMegaSalto));
        }
    }
}
