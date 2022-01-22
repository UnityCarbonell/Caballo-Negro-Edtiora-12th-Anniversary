using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;


    public int Mensaje = 0;

    public GameObject Perdido;
    public GameObject Caballo;
    public GameObject Obstaculos;

    public Text txtMensaje;

    void Start()
    {
        Perdido.SetActive(false);
        Mensaje = 0;
        ActualizarMensaje();
    }

    public void Jugar()
    {
        StartCoroutine(ChangeScreen(1));
    }

    public void Menu()
    {
        StartCoroutine(ChangeScreen(0));
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Instrucciones()
    {
       StartCoroutine(ChangeScreen(2));
    }

    public void CompletarMensaje()
    {
        Mensaje = Mensaje + 1;

        ActualizarMensaje();
    }

    public void Perder()
    {
        Perdido.SetActive(true);
    }

    public void ActualizarMensaje()
    {
        switch (Mensaje)
        {
            case 0:
                txtMensaje.text=" ";
                break;
            case 1:
                txtMensaje.text = "C"; 
                break;
            case 2:
                txtMensaje.text = "Ca";
                break;
            case 3:
                txtMensaje.text = "Cab";
                break;
            case 4:
                txtMensaje.text = "Caba";
                break;
            case 5:
                txtMensaje.text = "Cabal";
                break;
            case 6:
                txtMensaje.text = "Caball";
                break;
            case 7:
                txtMensaje.text = "Caballo";
                break;
            case 8:
                txtMensaje.text = "Caballo n";
                break;
            case 9:
                txtMensaje.text = "Caballo ne";
                break;
            case 10:
                txtMensaje.text = "Caballo neg";
                break;
            case 11:
                txtMensaje.text = "Caballo negr";
                break;
            case 12:
                txtMensaje.text = "Caballo negro";
                break;
            case 13:
                txtMensaje.text = "Caballo negro e";
                break;
            case 14:
                txtMensaje.text = "Caballo negro ed";
                break;
            case 15:
                txtMensaje.text = "Caballo negro edi";
                break;
            case 16:
                txtMensaje.text = "Caballo negro edit";
                break;
            case 17:
                txtMensaje.text = "Caballo negro edito";
                break;
            case 18:
                txtMensaje.text = "Caballo negro editor";
                break;
            case 19:
                txtMensaje.text = "Caballo negro editora,";
                break;
            case 20:
                txtMensaje.text = "Caballo negro editora, d";
                break;
            case 21:
                txtMensaje.text = "Caballo negro editora, do";
                break;
            case 22:
                txtMensaje.text = "Caballo negro editora, doc";
                break;
            case 23:
                txtMensaje.text = "Caballo negro editora, doce";
                break;
            case 24:
                txtMensaje.text = "Caballo negro editora, doce a";
                break;
            case 25:
                txtMensaje.text = "Caballo negro editora, doce añ";
                break;
            case 26:
                txtMensaje.text = "Caballo negro editora, doce año";
                break;
            case 27:
                txtMensaje.text = "Caballo negro editora, doce años:";
                break;
            case 28:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nm";
                break;
            case 29:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmá";
                break;
            case 30:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás";
                break;
            case 31:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás l";
                break;
            case 32:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás li";
                break;
            case 33:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás lib";
                break;
            case 34:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libr";
                break;
            case 35:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libro";
                break;
            case 36:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros,";
                break;
            case 37:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, m";
                break;
            case 38:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, má";
                break;
            case 39:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más";
                break;
            case 40:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más i";
                break;
            case 41:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más id";
                break;
            case 42:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ide";
                break;
            case 43:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más idea";
                break;
            case 44:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas,";
                break;
            case 45:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, m";
                break;
            case 46:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, má";
                break;
            case 47:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más";
                break;
            case 48:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más l";
                break;
            case 49:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más le";
                break;
            case 50:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más lec";
                break;
            case 51:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más lect";
                break;
            case 52:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más lecto";
                break;
            case 53:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más lector";
                break;
            case 54:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más lectore";
                break;
            case 55:
                txtMensaje.text = "Caballo negro editora, doce años:" + "\nmás libros, más ideas, más lectores.";
                Ganar();
                break;
        }
    }

    public void Ganar()
    {
        Caballo.GetComponent<ControlCaballo>().GanarCaballo();
    }

    public void OcultarObstaculos()
    {
        Obstaculos.SetActive(false);
    }

    IEnumerator ChangeScreen(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
