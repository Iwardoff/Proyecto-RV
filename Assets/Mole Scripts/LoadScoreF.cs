using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScoreF : MonoBehaviour
{
    public Text Puntaje1;
    public Text Puntaje2;
    public Text Ganador;
    public Text Ganador2;
    public Text Ganador3;
    public Text Empate;



    // Use this for initialization
    void Start()
    {
        Puntaje1.text = "Puntaje 1: " + PlayerPrefs.GetInt("Puntaje1").ToString();
        Puntaje2.text = "Puntaje 2: " + PlayerPrefs.GetInt("Puntaje2").ToString();
    }
    void Update()
    {
        if (Timer_Script.CurrentTime <= 0)
        {
            if(PlayerPrefs.GetInt("Puntaje1") > PlayerPrefs.GetInt("Puntaje2") && PlayerPrefs.GetInt("Puntaje1") > PlayerPrefs.GetInt("Puntaje3"))
            {
                Ganador.gameObject.SetActive(true);
                
                Ganador.text = "Ganador: Jugador 1";
            }

            else if (PlayerPrefs.GetInt("Puntaje2") > PlayerPrefs.GetInt("Puntaje1") && PlayerPrefs.GetInt("Puntaje2") > PlayerPrefs.GetInt("Puntaje3"))
            {
                Ganador2.gameObject.SetActive(true);

                Ganador2.text = "Ganador: Jugador 2";
            }

            else if (PlayerPrefs.GetInt("Puntaje3") > PlayerPrefs.GetInt("Puntaje1") && PlayerPrefs.GetInt("Puntaje3") > PlayerPrefs.GetInt("Puntaje2"))
            {
                Ganador3.gameObject.SetActive(true);

                Ganador3.text = "Ganador: Jugador 3";
            }

            else if (PlayerPrefs.GetInt("Puntaje3") == PlayerPrefs.GetInt("Puntaje1") && PlayerPrefs.GetInt("Puntaje3") == PlayerPrefs.GetInt("Puntaje2"))
            {
                Empate.gameObject.SetActive(true);

                Empate.text = "Triple Empate";
            }

        }
    }
}
