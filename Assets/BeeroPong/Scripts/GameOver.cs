﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public adminPuntos Player1;
    public Timer taim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if((SceneManager.GetActiveScene().buildIndex)<= 1){
                if(adminPuntos.PuntajeRef >= 6||taim.tiempo ==0){
                SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1); 
            }
        }
        else
        {
            SceneManager.LoadScene (2);
        }
    }  
} 
    

