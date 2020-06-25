using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScore : MonoBehaviour
{

    public Text Puntaje;

    // Use this for initialization
    void Start()
    {
        Puntaje.text = "Puntaje 1: " + PlayerPrefs.GetInt("Puntaje1").ToString();
    }
}
