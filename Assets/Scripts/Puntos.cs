using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{


    public static int Score = 0;
    public string ScoreString = "Score";
    public Text TextScore;
    public static Puntos GameController;

    void Awake()
    {
        GameController = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString();
        }
    }
}

