using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lanzardardo : MonoBehaviour
{

    public Rigidbody dardoPrefab;
    public Transform lanzador;
    public float VelDisparo;
    //public float tiempoDisparo;
   // public float inicioDisparo;
    
    //&& Time.time > inicioDisparo
    // Update is called once per frame
   private void Update()
    { 
        if(Input.GetButtonDown("Fire1") ) // fire1 para clic derecho 
        { // se instancia el dardo como un prefab y se le da la posicion desde donde saldra

      //      inicioDisparo = Time.time + tiempoDisparo;
            Rigidbody dardoPrefabInstanc;
            
            dardoPrefabInstanc = Instantiate(dardoPrefab, lanzador.position,
                Quaternion.identity) as Rigidbody;
            dardoPrefabInstanc.AddForce(lanzador.forward * 100 * VelDisparo);
           

        }
        
    }
}
