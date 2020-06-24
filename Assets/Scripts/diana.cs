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
      
        if (Diana.tag=="Player")
        {
            puntosintento2.score += 20;
        }
    }
}


