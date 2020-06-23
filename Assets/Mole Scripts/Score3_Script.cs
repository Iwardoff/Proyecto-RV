using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Score3_Script : MonoBehaviour
{

    private static int score3;
    public Text Puntaje3;

    public static int Score3
    {
        get
        {
            return score3;
        }

        set
        {
            score3 = value;
        }
    }


    // Use this for initialization
    void Start()
    {
        score3 = 0;
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Puntaje3", score3);
        PlayerPrefs.Save();

    }

    // Update is called once per frame
    void Update()
    {
        Puntaje3.text = "Puntaje 3: " + score3.ToString();



    }
}