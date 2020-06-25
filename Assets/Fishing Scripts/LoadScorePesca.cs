using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScorePesca : MonoBehaviour
{

    public Text Puntaje;

    // Use this for initialization
    void Start()
    {
        Puntaje.text = "Puntaje V: " + PlayerPrefs.GetInt("PuntajeV").ToString();
    }
}
