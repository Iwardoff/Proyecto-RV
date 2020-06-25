using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    private int score;
    public Text Puntaje;
    
    

    void Start()
    {
        score = 0;
        PlayerPrefs.SetInt("PuntajeV", score);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PezV")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score += 2;
            
        }
        else if (collision.gameObject.tag == "Pez_Rojo")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score -= 1;
        }
        else if (collision.gameObject.tag == "Pez_Amarillo")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score -= 1;
        }

    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt("PuntajeV", score);
        PlayerPrefs.Save();

    }
    void Update()
    {
        Puntaje.text = "Puntaje V: " + score.ToString();
    }


}