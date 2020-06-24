using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class diana : MonoBehaviour
{
    public puntosintento2 puntos;
    public GameObject dardo1;

     void Start()
    {
        dardo1 = GameObject.Find("Dardo");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "20")
        {
            puntosintento2.score += 20;
        }
    }
}


