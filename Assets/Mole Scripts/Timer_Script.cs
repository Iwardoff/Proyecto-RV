﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Timer_Script : MonoBehaviour {

    public float gameTime = 30.0F;
    private static float currentTime;
    public Text countdownText;

    public static float CurrentTime
    {
        get
        {
            return currentTime;
        }

        set
        {
            currentTime = value;
        }
    }

 
    // Use this for initialization
    void Awake () {
        currentTime = gameTime+1;
	}

	
	// Update is called once per frame
	void Update () {
        if (!PauseMenu_Script.IsPaused)
            currentTime -= Time.deltaTime;
        if (currentTime <= 0)
            currentTime = 0;
        countdownText.text = "Tiempo: " + ((int)currentTime).ToString();
	}
}
