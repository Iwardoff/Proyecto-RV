using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScorePescaF : MonoBehaviour
{ 

public Text Puntaje1;
public Text Puntaje2;
public Text Ganador;
public Text Ganador2;
public Text Ganador3;
public Text Empate;

    // Start is called before the first frame update
    void Start()
    {
        Puntaje1.text = "Puntaje V: " + PlayerPrefs.GetInt("PuntajeV").ToString();
        Puntaje2.text = "Puntaje A: " + PlayerPrefs.GetInt("PuntajeA").ToString();
    }


    // Update is called once per frame
    void Update()
    {
        if (Timer_Script.CurrentTime <= 0)
        {
            if (PlayerPrefs.GetInt("PuntajeV") > PlayerPrefs.GetInt("PuntajeA") && PlayerPrefs.GetInt("PuntajeV") > PlayerPrefs.GetInt("PuntajeR"))
            {
                Ganador.gameObject.SetActive(true);

                Ganador.text = "Ganador: Jugador Verde";
            }

            else if (PlayerPrefs.GetInt("PuntajeA") > PlayerPrefs.GetInt("PuntajeV") && PlayerPrefs.GetInt("PuntajeA") > PlayerPrefs.GetInt("PuntajeR"))
            {
                Ganador2.gameObject.SetActive(true);

                Ganador2.text = "Ganador: Jugador Amarillo";
            }

            else if (PlayerPrefs.GetInt("PuntajeR") > PlayerPrefs.GetInt("PuntajeV") && PlayerPrefs.GetInt("PuntajeR") > PlayerPrefs.GetInt("PuntajeA"))
            {
                Ganador3.gameObject.SetActive(true);

                Ganador3.text = "Ganador: Jugador Rojo";
            }

            else if (PlayerPrefs.GetInt("PuntajeR") == PlayerPrefs.GetInt("PuntajeV") && PlayerPrefs.GetInt("PuntajeR") == PlayerPrefs.GetInt("PuntajeA"))
            {
                Empate.gameObject.SetActive(true);

                Empate.text = "Triple Empate";
            }

        }
    }
}
