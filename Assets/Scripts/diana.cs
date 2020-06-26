using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class diana : MonoBehaviour
{
    
    public GameObject dardo1;

     void Start()
    {
        dardo1 = GameObject.Find("Dardo");
    }

    private void OnTriggerEnter(Collider Diana)
    {
      
        if (Diana.gameObject.tag=="Player")
        {
            puntosintento2.score += 20;
            Debug.Log("tiene 20 puntos");

        }if (Diana.gameObject.tag == "10")
        {
          
            Debug.Log("tiene 10 puntos");

        }

        if (Diana.gameObject.tag == "18")
        {
            Debug.Log("tiene 18 puntos");
        }

        if (Diana.gameObject.tag == "1")
        {
            Debug.Log("tiene 1 puntos");
        }
        if (Diana.gameObject.tag == "4")
        {
            Debug.Log("tiene 4 puntos");
        }
        if (Diana.gameObject.tag == "13")
        {
            Debug.Log("tiene 13 puntos");
        }
        if (Diana.gameObject.tag == "6")
        {
            Debug.Log("tiene 6 puntos");
        }
    }
}


