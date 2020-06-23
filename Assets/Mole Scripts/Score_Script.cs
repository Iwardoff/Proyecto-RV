using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour {

    private static int score1;
    public Text Puntaje1;

    //public Text Puntaje2;
    //public Text Puntaje3;

    public static int Score
    {
        get
        {
            return score1;
        }

        set
        {
            score1 = value;
        }
    }
  

    // Use this for initialization
    void Start () {
        score1 = 0;
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Puntaje1", score1);
        PlayerPrefs.Save();
     
    }


    // Update is called once per frame
    void Update () {
        Puntaje1.text = "Puntaje 1: " + score1.ToString();
    }
}
