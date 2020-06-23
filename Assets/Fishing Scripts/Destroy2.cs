using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy2 : MonoBehaviour
{
    private int score2;
    public Text Puntaje;



    void Start()
    {
        score2 = 0;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PezV")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score2 -= 1;

        }
        else if (collision.gameObject.tag == "Pez_Rojo")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score2 -= 1;
        }
        else if (collision.gameObject.tag == "Pez_Amarillo")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score2 += 2;
        }

    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt("Puntaje 2", score2);
        PlayerPrefs.Save();

    }
    void Update()
    {
        Puntaje.text = "Puntaje 2: " + score2.ToString();
    }


}