using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
 
    
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "PezV")
        { //object has the Pickup tag assigned.

            Destroy(collision.gameObject);
            Debug.Log("Funciona");
        }
        else if (collision.gameObject.tag == "Pez_Rojo")
        { //object has the Pickup tag assigned.


            Debug.Log("Gonorrea");
        }
        else if (collision.gameObject.tag == "Pez_Amarillo")
        { //object has the Pickup tag assigned.


            Debug.Log("Hpta");
        }

    }


}