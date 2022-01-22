using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    public GameObject Caballo;
    public Camera CamaraDeJuego;
    public bool GanarCamara = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (GanarCamara)
        {
            CamaraDeJuego.transform.position =
                   new Vector3(Caballo.transform.position.x + 6,
                   CamaraDeJuego.transform.position.y,
                   CamaraDeJuego.transform.position.z);
        }
        else
        {
            if (Caballo != null)
            {
                CamaraDeJuego.transform.position =
                    new Vector3(Caballo.transform.position.x,
                    CamaraDeJuego.transform.position.y,
                    CamaraDeJuego.transform.position.z);
            }
        }
    }

    public void CamaraGanada()
    {
        GanarCamara = true;
    }
}
