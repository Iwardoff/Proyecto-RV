using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detector : MonoBehaviour
{
    public lanzardardo disparar;
    public int contador;
    // Start is called before the first frame update
    void Start()
    {
        contador = 0;
    }

   

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            contador += 1;
            Boolean detector = false;
        }
    }
}
