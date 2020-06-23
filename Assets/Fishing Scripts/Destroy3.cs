using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy3 : MonoBehaviour
{
    private int score3;
    public Text Puntaje;



    void Start()
    {
        score3 = 0;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PezV")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score3 -= 1;

        }
        else if (collision.gameObject.tag == "Pez_Rojo")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score3 += 2;
        }
        else if (collision.gameObject.tag == "Pez_Amarillo")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            score3 -= 1;
        }

    }
    void OnDestroy()
    {
        PlayerPrefs.SetInt("Puntaje 3", score3);
        PlayerPrefs.Save();

    }
    void Update()
    {
        Puntaje.text = "Puntaje 3: " + score3.ToString();
    }


}