using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score2_Script : MonoBehaviour
{

    private static int score2;
  
    public Text Puntaje2;
    //public Text Puntaje3;

    public static int Score
    {
        get
        {
            return score2;
        }

        set
        {
            score2 = value;
        }
    }


    // Use this for initialization
    void Start()
    {
        score2 = 0;
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Puntaje2", score2);
        PlayerPrefs.Save();

    }

    // Update is called once per frame
    void Update()
    {
        Puntaje2.text = "Puntaje 2: " + score2.ToString();
    }
}