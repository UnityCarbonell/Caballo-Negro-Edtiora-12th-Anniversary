using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCaballo : MonoBehaviour
{
    public int Salto;
    public int Velocidad;
    bool Suelo = false;
    bool Ganar = false;
    bool TriggerFinal = false;

    public GameManager GameManager;
    public GameObject ControladorDeCamara;
    public GameObject Credito;
    public Animator Creditos;

    void Start()
    {
        this.GetComponent<Rigidbody2D>().transform.position = new Vector3(0, 2.5f);
        Credito.SetActive(false);
    }

    
    void Update()
    {
        if (Ganar && TriggerFinal)
        {
            GameManager.GetComponent<GameManager>().OcultarObstaculos();
            ControladorDeCamara.GetComponent<ControlCamara>().CamaraGanada();
            this.GetComponent<Rigidbody2D>().transform.position = new Vector3(753.68f, 2.33f);
            Creditos.SetBool("Final", true);
        }
        else
        {
            if (Input.GetKeyDown("space") && Suelo)
            {
                Suelo = false;
                this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, Salto));
            }

            this.GetComponent<Rigidbody2D>().velocity = new Vector2(Velocidad, this.GetComponent<Rigidbody2D>().velocity.y);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D choque)
    {
        Suelo = true;

        if (choque.collider.gameObject.tag == "Letra")
        {
            GameObject.Destroy(this.gameObject);

            GameManager.GetComponent<GameManager>().Perder();
        }
    }

    private void OnTriggerEnter2D(Collider2D choque)
    {
        if (Ganar)
        {
            TriggerFinal = true;
            Credito.SetActive(true);
        }
        else
        {
            GameManager.GetComponent<GameManager>().CompletarMensaje();
        }
    }

    public void GanarCaballo()
    {
        Ganar = true;
    }
}
