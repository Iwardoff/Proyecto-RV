using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class diana : MonoBehaviour
{
    
    public int Puntaje = 20;
   

    void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.CompareTag("Diana"))
        {
             Puntos.Score += Puntaje;
         
        }
    }
   
}


