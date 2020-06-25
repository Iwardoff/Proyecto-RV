using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class adminPuntos : MonoBehaviour
{
    
    public string scoreText = "Puntaje:";

    public Text textScore;
    public static adminPuntos admnPuntos;
    public  int Puntaje;
    public static int PuntajeRef = 0;
    public Timer timer;

    void Awake(){
        admnPuntos = this;
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
        if(textScore != null)
        {
            textScore.text = scoreText + PuntajeRef.ToString();
        }

        if(adminPuntos.PuntajeRef >=6||timer.GetComponent<tiempo>() == 0){
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);}
            
        }

    }


