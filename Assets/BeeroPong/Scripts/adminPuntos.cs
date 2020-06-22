using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adminPuntos : MonoBehaviour
{
    public int vasosRestantes = 6;
    public string scoreText = "Puntaje:";
    public string vidasText = "Vasos Restantes:";

    public Text textScore;
    public Text textVidas;
    public static adminPuntos admnPuntos;
    public int Puntaje;

    void Awake(){
        admnPuntos = this;
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
            textScore.text = scoreText + Puntaje.ToString();
            textVidas.text = vidasText + vasosRestantes.ToString();
        }

        if(Puntaje == 6){
            
        }

    }

}
